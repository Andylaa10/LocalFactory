import {Component, Inject, OnInit} from '@angular/core';
import {CustomerService} from "../../shared/service/customer.service";
import {ActivatedRoute, Router} from "@angular/router";
import {Customer} from "../../shared/models/customer";
import {FormControl, FormGroup} from "@angular/forms";
import {OrderService} from "../../shared/service/order.service";
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";

@Component({
  selector: 'app-customer-details',
  templateUrl: './customer-details.component.html',
  styleUrls: ['./customer-details.component.scss']
})
export class CustomerDetailsComponent implements OnInit {
  customer: Customer = new Customer();
  orders: any[] = [];

  customerForm = new FormGroup({
    id: new FormControl(this.data.customer.id),
    firstName: new FormControl(this.data.customer.firstName),
    lastName: new FormControl(this.data.customer.lastName),
    email: new FormControl(this.data.customer.email),
  });

  constructor(private customerService: CustomerService, private route: ActivatedRoute, private router: Router, private orderService: OrderService, public dialogRef: MatDialogRef<CustomerDetailsComponent>, @Inject(MAT_DIALOG_DATA) public data : any) { }

  async ngOnInit(){
    this.customer = await this.customerService.getCustomerById(this.data.customer.id);
    await this.getCustomerOrders(this.data.customer.id);
    this.customerForm.patchValue({
      id: this.customer.id,
      firstName: this.customer.firstName,
      lastName: this.customer.lastName,
      email: this.customer.email
    });
  }

  async save() {
    const customer = this.customerForm.value;
    let dto ={
      id: customer.id,
      firstName: customer.firstName,
      lastName: customer.lastName,
      email: customer.email
    }
    await this.customerService.updateCustomer(dto, customer.id)
    this.dialogRef.close();
  }

  async getCustomerOrders(customerId: number){
    const orders = await this.orderService.getCustomersOrder(customerId);
    this.orders = orders;
  }
}
