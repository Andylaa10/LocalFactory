import { Component, OnInit } from '@angular/core';
import {OrderService} from "../../../shared/service/order.service";
import {ActivatedRoute, Router} from "@angular/router";

@Component({
  selector: 'app-my-orders',
  templateUrl: './my-orders.component.html',
  styleUrls: ['./my-orders.component.scss']
})
export class MyOrdersComponent implements OnInit {
  orders: any[] = [];

  constructor(private orderService: OrderService, private route: ActivatedRoute, private router: Router) { }

  async ngOnInit(){
    const customerId = Number(this.route.snapshot.paramMap.get('id'));
    await this.getMyOrders(customerId);
  }

  async getMyOrders(customerId: number){
    const orders = await this.orderService.getCustomersOrder(customerId);
    this.orders = orders;
  }

}
