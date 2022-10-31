import { Component, OnInit } from '@angular/core';
import {Customer} from "../../models/customer";
import {CustomerService} from "../../service/customer.service";

@Component({
  selector: 'app-customer-navbar',
  templateUrl: './customer-navbar.component.html',
  styleUrls: ['./customer-navbar.component.scss']
})
export class CustomerNavbarComponent implements OnInit {
  customers: any[] = [];
  parentData: Customer = new Customer();


  constructor(private customerService: CustomerService) {
  }

  async ngOnInit(){
    await this.getCustomers();
  }

  async getCustomers(){
    const customers = await this.customerService.getCustomers();
    this.customers = customers;
  }
}
