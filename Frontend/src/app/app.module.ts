import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavbarComponent } from './shared/navbar/navbar.component';
import { FrontPageComponent } from './shared/front-page/front-page.component';
import {MatIconModule} from "@angular/material/icon";
import { AdminViewComponent } from './admin-view/admin-view.component';
import { CustomerViewComponent } from './Customer/customer-view/customer-view.component';
import { CustomerListComponent } from './Customer/customer-list/customer-list.component';
import {MatCardModule} from "@angular/material/card";
import {MatButtonModule} from "@angular/material/button";
import { CustomerDetailsComponent } from './Customer/customer-details/customer-details.component';
import {FormsModule, ReactiveFormsModule} from "@angular/forms";
import {MatFormFieldModule} from "@angular/material/form-field";
import {MatInputModule} from "@angular/material/input";
import { CustomerAddComponent } from './Customer/customer-add/customer-add.component';
import { BoxListComponent } from './Box/box-list/box-list.component';
import { BoxAddComponent } from './Box/box-add/box-add.component';
import { BoxDetailsComponent } from './Box/box-details/box-details.component';
import { OrderListComponent } from './Order/order-list/order-list.component';
import { CustomerNavbarComponent } from './shared/navbar/customer-navbar/customer-navbar.component';
import {MatSelectModule} from "@angular/material/select";
import { MyOrdersComponent } from './Customer/customer-view/my-orders/my-orders.component';
import {MatDialogModule} from "@angular/material/dialog";
import { BoxesComponent } from './Customer/customer-view/boxes/boxes.component';
import {FlexLayoutModule} from "@angular/flex-layout";
import {MatExpansionModule} from "@angular/material/expansion";
import {MatListModule} from "@angular/material/list";
import {ScrollingModule} from "@angular/cdk/scrolling";

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    FrontPageComponent,
    AdminViewComponent,
    CustomerViewComponent,
    CustomerListComponent,
    CustomerDetailsComponent,
    CustomerAddComponent,
    BoxListComponent,
    BoxAddComponent,
    BoxDetailsComponent,
    OrderListComponent,
    CustomerNavbarComponent,
    MyOrdersComponent,
    BoxesComponent
  ],
    imports: [
        BrowserModule,
        AppRoutingModule,
        BrowserAnimationsModule,
        MatIconModule,
        MatCardModule,
        MatButtonModule,
        ReactiveFormsModule,
        MatFormFieldModule,
        MatInputModule,
        FormsModule,
        MatSelectModule,
        MatDialogModule,
        FlexLayoutModule,
        MatExpansionModule,
        MatListModule,
        ScrollingModule,
    ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
