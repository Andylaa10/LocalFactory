import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {AdminViewComponent} from "./admin-view/admin-view.component";
import {FrontPageComponent} from "./shared/front-page/front-page.component";
import {CustomerViewComponent} from "./Customer/customer-view/customer-view.component";
import {CustomerListComponent} from "./Customer/customer-list/customer-list.component";
import {CustomerDetailsComponent} from "./Customer/customer-details/customer-details.component";
import {CustomerAddComponent} from "./Customer/customer-add/customer-add.component";

const routes: Routes = [
  {path: '', component: FrontPageComponent},
  {path: 'admin-view', component: AdminViewComponent},
  {path: 'customer-view', component: CustomerViewComponent},
  {path: 'customer-list', component: CustomerListComponent},
  {path: 'customer/:id', component: CustomerDetailsComponent},
  {path: 'customer', component: CustomerAddComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
