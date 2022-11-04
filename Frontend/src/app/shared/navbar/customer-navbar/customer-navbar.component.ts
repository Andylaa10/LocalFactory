import {Component, OnInit} from '@angular/core';
import {Customer} from "../../models/customer";
import {CustomerService} from "../../service/customer.service";
import {Router} from "@angular/router";
import {OrderService} from "../../service/order.service";

@Component({
  selector: 'app-customer-navbar',
  templateUrl: './customer-navbar.component.html',
  styleUrls: ['./customer-navbar.component.scss']
})
export class CustomerNavbarComponent implements OnInit {
  customers: any[] = [];
  customerFromParent: Customer = new Customer();

  constructor(public customerService: CustomerService, private orderService: OrderService) {
  }

  async ngOnInit(){
    await this.getCustomers();
  }

  async getCustomers(){
    await this.customerService.getCustomers();
  }

  resetOrders() {
    this.orderService.orders = [];
  }
}
