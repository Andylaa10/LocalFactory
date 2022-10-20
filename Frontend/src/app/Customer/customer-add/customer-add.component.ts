import { Component, OnInit } from '@angular/core';
import {FormControl, FormGroup} from "@angular/forms";
import {CustomerService} from "../../shared/service/customer.service";
import {Router} from "@angular/router";

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

  constructor(private customerService: CustomerService, private router: Router) { }

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
    await this.router.navigateByUrl('/customer-list');
  }

}
