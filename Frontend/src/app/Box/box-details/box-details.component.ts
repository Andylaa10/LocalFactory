import {Component, Inject, OnInit} from '@angular/core';
import {Box} from "../../shared/models/box";
import {FormControl, FormGroup} from "@angular/forms";
import {BoxService} from "../../shared/service/box.service";
import {ActivatedRoute, Router} from "@angular/router";
import {OrderService} from "../../shared/service/order.service";
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";

@Component({
  selector: 'app-box-details',
  templateUrl: './box-details.component.html',
  styleUrls: ['./box-details.component.scss']
})
export class BoxDetailsComponent implements OnInit {
  box: Box = new Box();
  orders: any[] = [];

  boxForm = new FormGroup({
    id: new FormControl(this.data.box.id),
    photo: new FormControl(this.data.box.photo),
    boxName: new FormControl(this.data.box.boxName),
    description: new FormControl(this.data.box.description),
    price: new FormControl(this.data.box.price)
  });

  constructor(private boxService: BoxService, private route: ActivatedRoute, private router: Router, private orderService: OrderService, public dialogRef: MatDialogRef<BoxDetailsComponent>, @Inject(MAT_DIALOG_DATA) public data : any) {
  }

  async ngOnInit(){
    this.box = await this.boxService.getBoxById(this.data.box.id);
    await this.getBoxOrders(this.data.box.id);
    this.boxForm.patchValue({
      id: this.box.id,
      photo: this.box.photo,
      boxName: this.box.boxName,
      description: this.box.description,
      price: this.box.price
    });
  }

  async save() {
    const box = this.boxForm.value;
    let dto ={
      id: box.id,
      boxName: box.boxName,
      description: box.description,
      price: box.price
    }
    await this.boxService.updateBox(dto, box.id)
    this.dialogRef.close();

  }

  async getBoxOrders(boxId: number){
    const orders = await this.orderService.getBoxesOrder(boxId);
    this.orders = orders;
  }

}
