import { Component, OnInit } from '@angular/core';
import {CustomerService} from "../../shared/service/customer.service";

@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrls: ['./customer-list.component.scss']
})
export class CustomerListComponent implements OnInit {
  customers: any[] = [];
  constructor(private customerService: CustomerService) {
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

}
