import {Component, OnInit} from '@angular/core';
import {FormControl, FormGroup} from "@angular/forms";
import {CustomerService} from "../../shared/service/customer.service";
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";

@Component({
  selector: 'app-customer-add',
  templateUrl: './customer-add.component.html',
  styleUrls: ['./customer-add.component.scss']
})
export class CustomerAddComponent implements OnInit {

  customerForm = new FormGroup({
    firstName: new FormControl(''),
    lastName: new FormControl(''),
    email: new FormControl('')
  })

  constructor(private customerService: CustomerService, public dialogRef: MatDialogRef<CustomerAddComponent>) { }

  ngOnInit(): void {
  }

  async save(){
    const customer = this.customerForm.value;
    let dto = {
      firstName: customer.firstName,
      lastName: customer.lastName,
      email: customer.email
    }
    await this.customerService.addCustomer(dto);
    await this.customerForm.reset();
    this.dialogRef.close();
  }

}
