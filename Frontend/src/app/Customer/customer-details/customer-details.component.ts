import {Component, OnInit} from '@angular/core';
import {CustomerService} from "../../shared/service/customer.service";
import {ActivatedRoute, Router} from "@angular/router";
import {Customer} from "../../shared/models/customer";
import {FormControl, FormGroup} from "@angular/forms";
import {BoxService} from "../../shared/service/box.service";

@Component({
  selector: 'app-customer-details',
  templateUrl: './customer-details.component.html',
  styleUrls: ['./customer-details.component.scss']
})
export class CustomerDetailsComponent implements OnInit {
  customer: Customer = new Customer();

  customerForm = new FormGroup({
    id: new FormControl(),
    firstName: new FormControl(''),
    lastName: new FormControl(''),
    email: new FormControl(''),
    //boxes: new FormGroup(this.boxService.getBoxes())
  })

  constructor(private customerService: CustomerService, private route: ActivatedRoute, private router: Router, private boxService: BoxService) { }

  async ngOnInit(){
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.customer = await this.customerService.getCustomerById(id);
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
    await this.router.navigateByUrl('/customer-list');
  }
}
