import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';
import {BoxService} from "../../../shared/service/box.service";
import {Customer} from "../../../shared/models/customer";
import {OrderService} from "../../../shared/service/order.service";
import {MyOrdersComponent} from "../my-orders/my-orders.component";

@Component({
  selector: 'app-boxes',
  templateUrl: './boxes.component.html',
  styleUrls: ['./boxes.component.scss']
})
export class BoxesComponent implements OnInit{
  @Input() inputFromParent : Customer = new Customer();

  constructor(public boxService: BoxService, private orderService: OrderService) { }

  async ngOnInit(){
    await this.boxService.getBoxes();
  }

  async addOrder(boxId: any) {
    let dto = {
      customerId:this.inputFromParent.id,
      boxId: boxId
    }
    const newOrder = await this.orderService.addOrder(dto);
    this.orderService.orders.push(newOrder);
    //MyOrdersComponent.bind(this.orderService.getCustomersOrder(this.inputFromParent.id))
  }

}
