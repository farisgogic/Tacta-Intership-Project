export interface CreateShoppingListRequest {
    shopperId: number;
    itemId: number[];
  }
  
  export interface ShoppingList {
    shopperId: number;
    itemId: number;
  }