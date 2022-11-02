import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';
import {Customer} from "../../models/customer";
import {CustomerService} from "../../service/customer.service";

@Component({
  selector: 'app-customer-navbar',
  templateUrl: './customer-navbar.component.html',
  styleUrls: ['./customer-navbar.component.scss']
})
export class CustomerNavbarComponent implements OnInit {
  customers: any[] = [];
  customerFromParent: Customer = new Customer();

  constructor(public customerService: CustomerService) {
  }

  async ngOnInit(){
    await this.getCustomers();
  }

  async getCustomers(){
    await this.customerService.getCustomers();

  }
}
