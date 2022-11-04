import { Component, OnInit } from '@angular/core';
import {OrderService} from "../../shared/service/order.service";
import {CustomerService} from "../../shared/service/customer.service";

@Component({
  selector: 'app-order-list',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.scss']
})
export class OrderListComponent implements OnInit {
  customerOnOrders: any[] = [];
  panelOpenState = false;

  constructor(public orderService: OrderService, public customerService: CustomerService) { }

  async ngOnInit(){
    await this.orderService.getOrders();
  }

  async deleteOrder(id: number){
    await this.orderService.deleteOrder(id)
  }

  async getCustomerOnOrder(customerId: number){
    const customerOnOrder = await this.orderService.getCustomersOrder(customerId);
    this.customerOnOrders = customerOnOrder;
  }

}
