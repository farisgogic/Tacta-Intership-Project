import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SavedListsComponent } from './saved-lists/saved-lists.component';
import { ShoppersListsComponent } from './shoppers-lists/shoppers-lists.component';
import { HomeScreenComponent } from './home-screen/home-screen.component';

const routes: Routes = [
  { path: 'shoppers-lists', component: ShoppersListsComponent },
  { path: 'saved-lists/:shopperId', component: SavedListsComponent },
  { path: '**', component: HomeScreenComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
