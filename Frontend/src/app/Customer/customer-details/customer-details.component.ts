import {Component, Inject, OnInit} from '@angular/core';
import {CustomerService} from "../../shared/service/customer.service";
import {Customer} from "../../shared/models/customer";
import {FormControl, FormGroup} from "@angular/forms";
import {OrderService} from "../../shared/service/order.service";
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";

@Component({
  selector: 'app-customer-details',
  templateUrl: './customer-details.component.html',
  styleUrls: ['./customer-details.component.scss']
})
export class CustomerDetailsComponent implements OnInit{
  customer: Customer = new Customer();

  customerForm = new FormGroup({
    id: new FormControl(this.data.customer.id),
    firstName: new FormControl(this.data.customer.firstName),
    lastName: new FormControl(this.data.customer.lastName),
    email: new FormControl(this.data.customer.email)
  });

  constructor(private customerService: CustomerService, public orderService: OrderService, public dialogRef: MatDialogRef<CustomerDetailsComponent>, @Inject(MAT_DIALOG_DATA) public data : any) {

  }

  async ngOnInit(){
    this.customer = await this.customerService.getCustomerById(this.data.customer.id);
    await this.getCustomerOrders(this.data.customer.id);
  }

  async save() {
    const cust = this.customerForm.value;
    let dto ={
      id: cust.id,
      firstName: cust.firstName,
      lastName: cust.lastName,
      email: cust.email
    };
    let c = await this.customerService.updateCustomer(dto, cust.id)
    this.customerService.customers.map(obj => {
      if (obj == cust.id){
        obj = c;
        return obj;
      }
    });
    this.dialogRef.close();
  }

  async getCustomerOrders(customerId: number){
    await this.orderService.getCustomersOrder(customerId);
  }
}
