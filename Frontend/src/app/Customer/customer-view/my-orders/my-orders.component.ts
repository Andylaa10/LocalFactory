import {Component, Input, OnChanges} from '@angular/core';
import {OrderService} from "../../../shared/service/order.service";
import {Customer} from "../../../shared/models/customer";

@Component({
  selector: 'app-my-orders',
  templateUrl: './my-orders.component.html',
  styleUrls: ['./my-orders.component.scss']
})
export class MyOrdersComponent implements OnChanges {
  @Input() inputFromParent : Customer = new Customer();

  panelOpenState: boolean = false;


  constructor(public orderService: OrderService) { }

  async ngOnChanges(){
    if (this.inputFromParent == null || this.inputFromParent == undefined){
      console.log("parent data is undefined or null");
    }else{
      await this.getMyOrders(this.inputFromParent.id);
    }
  }

  async getMyOrders(customerId: any){
    await this.orderService.getCustomersOrder(customerId);
  }

  async deleteOrder(id: number) {
    await this.orderService.deleteOrder(id);
    await this.getMyOrders(this.inputFromParent.id)
  }
}
