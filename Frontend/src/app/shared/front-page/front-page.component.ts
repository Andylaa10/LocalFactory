import { Component, OnInit } from '@angular/core';
import {OrderService} from "../service/order.service";

@Component({
  selector: 'app-front-page',
  templateUrl: './front-page.component.html',
  styleUrls: ['./front-page.component.scss']
})
export class FrontPageComponent implements OnInit {

  constructor(public orderService: OrderService) { }

  ngOnInit(): void {
  }

  resetOrders() {
    this.orderService.orders = [];
  }

}
