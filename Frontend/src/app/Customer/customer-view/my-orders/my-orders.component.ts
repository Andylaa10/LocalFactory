import {Component, EventEmitter, Input, OnChanges, OnInit, Output} from '@angular/core';
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
  @Input() inputFromParent : Customer = new Customer()

  constructor(private orderService: OrderService, private route: ActivatedRoute, private router: Router) { }

  async ngOnChanges(){
    //const id = this.route.snapshot.paramMap.get('id');
    if (this.inputFromParent == null || this.inputFromParent == undefined){
      console.log("parent data is undefined or null");
    }else{
      await this.getMyOrders(this.inputFromParent.id);
    }
  }

  async getMyOrders(customerId: any){
    const orders = await this.orderService.getCustomersOrder(customerId);
    this.orders = orders;
  }

}
