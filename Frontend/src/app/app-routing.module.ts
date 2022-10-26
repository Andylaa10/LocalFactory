import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {AdminViewComponent} from "./admin-view/admin-view.component";
import {FrontPageComponent} from "./shared/front-page/front-page.component";
import {CustomerViewComponent} from "./Customer/customer-view/customer-view.component";
import {CustomerListComponent} from "./Customer/customer-list/customer-list.component";
import {CustomerDetailsComponent} from "./Customer/customer-details/customer-details.component";
import {CustomerAddComponent} from "./Customer/customer-add/customer-add.component";
import {BoxListComponent} from "./Box/box-list/box-list.component";
import {BoxDetailsComponent} from "./Box/box-details/box-details.component";
import {BoxAddComponent} from "./Box/box-add/box-add.component";
import {OrderListComponent} from "./Order/order-list/order-list.component";
import {MyOrdersComponent} from "./Customer/customer-view/my-orders/my-orders.component";

const routes: Routes = [
  {path: '', component: FrontPageComponent},
  {path: 'admin-view', component: AdminViewComponent},
  {path: 'customer-view', component: CustomerViewComponent},
  {path: 'customer-list', component: CustomerListComponent},
  {path: 'customer/:id', component: CustomerDetailsComponent},
  {path: 'customer', component: CustomerAddComponent},

  {path: 'box-list', component: BoxListComponent},
  {path: 'box/:id', component: BoxDetailsComponent},
  {path: 'box', component: BoxAddComponent},

  {path: 'order-list', component: OrderListComponent},
  {path: 'my-orders/:id', component: MyOrdersComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
