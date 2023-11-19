// saved-lists.component.ts

import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-saved-lists',
  templateUrl: './saved-lists.component.html',
  styleUrls: ['./saved-lists.component.css'],
})
export class SavedListsComponent implements OnInit {
  shopperId!: number;
  savedLists: any[] = [];
  shoppingItems!: any[];
  shoppers: any[] = [];

  constructor(
    private route: ActivatedRoute,
    private dataService: DataService
  ) {}

  ngOnInit(): void {
    this.route.params.subscribe((params) => {
      this.shopperId = +params['shopperId'];
      this.loadData();
    });
  }

  loadData(): void {
    this.dataService.getShoppingLists(this.shopperId).subscribe(
      (savedLists) => {
        this.savedLists = savedLists;
        this.loadShoppingItems();
      },
      (error) => console.error('Error loading saved lists:', error)
    );
  }

  loadShoppingItems(): void {
    this.dataService
      .getShoppingItems()
      .subscribe(
        (shoppingItems) => {
          this.shoppingItems = shoppingItems;
          this.fetchItemNames();
          this.fetchShopperNames();
        },
        (error) => console.error('Error loading shopping items:', error)
      );
  }

  fetchItemNames(): void {
    if (this.shoppingItems) {
      this.savedLists.forEach((savedItem) => {
        const item = this.shoppingItems.find((item) => item.itemId === savedItem.itemId);
        if (item) {
          savedItem.itemName = item.itemName;
        }
      });
    }
  }

  fetchShopperNames(): void {
    const shopperIds = this.savedLists.map((savedItem) => savedItem.shopperId);
    this.dataService.getShoppers().subscribe(
      (shoppers) => {
        this.shoppers = shoppers.filter((shopper) => shopperIds.includes(shopper.shopperId));
      },
      (error) => console.error('Error loading shopper names:', error)
    );
  }

  getShopperName(shopperId: number): string {
    const shopper = this.shoppers.find((shopper) => shopper.shopperId === shopperId);
    return shopper ? shopper.shopperName : 'Unknown Shopper';
  }
}
