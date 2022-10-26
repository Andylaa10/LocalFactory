import { Component, OnInit } from '@angular/core';
import {OrderService} from "../../shared/service/order.service";

@Component({
  selector: 'app-order-list',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.scss']
})
export class OrderListComponent implements OnInit {
  orders: any[] = [];
  customerOnOrders: any[] = [];

  constructor(private orderService: OrderService) { }

  async ngOnInit(){
    await this.getOrders();
  }

  async getOrders(){
    const orders = await this.orderService.getOrders();
    this.orders = orders;
  }

  async deleteOrder(id: number){
    const order = await this.orderService.deleteCustomer(id)
    this.orders = this.orders.filter(o => o.id != order.id);
  }

  async getCustomerOnOrder(customerId: number){
    const customerOnOrder = await this.orderService.getCustomersOrder(customerId);
    this.customerOnOrders = customerOnOrder;
  }

}
