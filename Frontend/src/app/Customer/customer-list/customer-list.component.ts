import {Component, OnInit} from '@angular/core';
import {CustomerService} from "../../shared/service/customer.service";
import {MatDialog} from "@angular/material/dialog";
import {CustomerAddComponent} from "../customer-add/customer-add.component";
import {Customer} from "../../shared/models/customer";
import {CustomerDetailsComponent} from "../customer-details/customer-details.component";

@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrls: ['./customer-list.component.scss']
})
export class CustomerListComponent implements OnInit {
  customers: any[] = [];

  constructor(private customerService: CustomerService, private popup: MatDialog) {
  }

  async ngOnInit(){
    await this.getCustomers();
  }

  async getCustomers(){
    const customers = await this.customerService.getCustomers();
    this.customers = customers;
  }

  async deleteCustomer(id: any){
    const customer = await this.customerService.deleteCustomer(id);
    this.customers = this.customers.filter(c => c.id !== customer.id);

  }

  async createCustomer() {
    const data = this.popup.open(CustomerAddComponent);
    data.afterClosed().subscribe(customer => {
      if (customer != null) {
        this.customers.push(customer);
      }
    });
  }

  detailCustomer(c: any) {
    const data = this.popup.open(CustomerDetailsComponent, {
      data: {
        customer : c
      }
    });
    data.afterClosed().subscribe();
  }
}
