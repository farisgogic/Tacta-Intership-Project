import { Component, OnInit } from '@angular/core';
import { DataService } from './services/data.service';
import { Shopper } from './models/shopper.model';
import { ShoppingItem } from './models/shopping-item.model';
import { CreateShoppingListRequest } from './models/shopping-list.model';
import Swal from 'sweetalert2';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  shoppers: Shopper[] = [];
  shoppingItems: ShoppingItem[] = [];
  shopperSelectedItems: { [shopperId: number]: number[] } = {};

  constructor(private dataService: DataService, private router: Router) {}

  ngOnInit(): void {
    this.loadShoppers();
    this.loadShoppingItems();
  }

  private loadShoppers(): void {
    this.dataService.getShoppers().subscribe((data) => (this.shoppers = data));
  }

  private loadShoppingItems(): void {
    this.dataService
      .getShoppingItems()
      .subscribe((data) => (this.shoppingItems = data));
  }

  isItemSelected(shopperId: number, itemId: number): boolean {
    return (this.shopperSelectedItems[shopperId] || []).includes(itemId);
  }

  toggleItemSelection(shopperId: number, itemId: number): void {
    const selectedItems = this.shopperSelectedItems[shopperId] || [];

    if (selectedItems.includes(itemId)) {
      this.shopperSelectedItems[shopperId] = selectedItems.filter(
        (id) => id !== itemId
      );
    } else {
      this.shopperSelectedItems[shopperId] = [...selectedItems, itemId];
    }
  }

  createShoppingList(shopperId: number): void {
    const selectedItems = this.shopperSelectedItems[shopperId] || [];
    const request: CreateShoppingListRequest = {
      shopperId: shopperId,
      itemId: selectedItems,
    };

    this.dataService.createShoppingList(request).subscribe(
      () => {
        this.loadShoppers();
        this.loadShoppingItems();
        Swal.fire('Success', 'Items are added to the shopper list.', 'success');
      },
      (error) => {
        Swal.fire(
          'Error',
          'You cannot add this item because this item is already in 3 shopping lists.',
          'error'
        );
      }
    );
  }
  viewSavedLists(shopperId: number): void {
    this.router.navigate(['/saved-lists', shopperId]);
    console.log(`View Saved Lists clicked for Shopper ID: ${shopperId}`);
  }
}
