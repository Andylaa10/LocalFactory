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
import {ReactiveFormsModule} from "@angular/forms";
import {MatFormFieldModule} from "@angular/material/form-field";
import {MatInputModule} from "@angular/material/input";
import { CustomerAddComponent } from './Customer/customer-add/customer-add.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    FrontPageComponent,
    AdminViewComponent,
    CustomerViewComponent,
    CustomerListComponent,
    CustomerDetailsComponent,
    CustomerAddComponent
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
    MatInputModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
