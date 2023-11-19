
import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, catchError, throwError } from 'rxjs';
import { Shopper } from '../models/shopper.model';
import { ShoppingItem } from '../models/shopping-item.model';
import { CreateShoppingListRequest, ShoppingList } from '../models/shopping-list.model';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  private baseUrl = 'http://localhost:7037/api';

  constructor(private http: HttpClient) {}

  getShoppers(): Observable<Shopper[]> {
    return this.http.get<Shopper[]>(`${this.baseUrl}/Shoppers`);
  }

  getShoppingItems(): Observable<ShoppingItem[]> {
    return this.http.get<ShoppingItem[]>(`${this.baseUrl}/Items`);
  }

  createShoppingList(request: CreateShoppingListRequest): Observable<ShoppingList> {
    return this.http.post<ShoppingList>(`${this.baseUrl}/Shoppers/createShoppingList`, request)
      .pipe(
        catchError((error: HttpErrorResponse) => {
          console.error('HTTP error occurred:', error);
          return throwError(error);
        })
      );
  }
  
  getShoppingLists(shopperId: number): Observable<ShoppingList[]> {
    return this.http.get<ShoppingList[]>(`${this.baseUrl}/Shoppers/shoppingLists/${shopperId}`);
  }
}
