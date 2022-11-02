import {Component, OnInit} from '@angular/core';
import {CustomerService} from "../../shared/service/customer.service";
import {MatDialog} from "@angular/material/dialog";
import {CustomerAddComponent} from "../customer-add/customer-add.component";
import {CustomerDetailsComponent} from "../customer-details/customer-details.component";

@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrls: ['./customer-list.component.scss']
})
export class CustomerListComponent implements OnInit {

  constructor(public customerService: CustomerService, private popup: MatDialog) {
  }

  async ngOnInit(){
    await this.customerService.getCustomers();
  }

  async deleteCustomer(id: any){
    await this.customerService.deleteCustomer(id);
  }

  async createCustomer() {
    const data = this.popup.open(CustomerAddComponent);
    data.afterClosed().subscribe(customer => {
      if (customer != null) {
        this.customerService.customers.push(customer);
      }
      this.customerService.getCustomers();
    });
  }

  detailCustomer(c: any) {
    const data = this.popup.open(CustomerDetailsComponent, {
      data: {
        customer : c
      }
    });
    data.afterClosed().subscribe(() =>{
      this.customerService.getCustomers();
    });
  }
}
