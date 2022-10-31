import {Component, Input, OnChanges, OnInit} from '@angular/core';
import {OrderService} from "../../../shared/service/order.service";
import {ActivatedRoute, Router} from "@angular/router";
import {Customer} from "../../../shared/models/customer";

@Component({
  selector: 'app-my-orders',
  templateUrl: './my-orders.component.html',
  styleUrls: ['./my-orders.component.scss']
})
export class MyOrdersComponent implements OnChanges {
  orders: any[] = [];
  @Input() customer = new Customer();
  constructor(private orderService: OrderService, private route: ActivatedRoute, private router: Router) { }

  async ngOnChanges(){
    //const id = this.route.snapshot.paramMap.get('id');
    await this.getMyOrders(this.customer.id);
  }

  async getMyOrders(customerId: any){
    const orders = await this.orderService.getCustomersOrder(customerId);
    this.orders = orders;
  }

}
