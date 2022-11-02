import { Injectable } from '@angular/core';
import axios from "axios";

export const customAxios =axios.create({
  //baseURL: 'https://localfactoryandy.azurewebsites.net'
  baseURL: 'https://localhost:7006'
});

@Injectable({
  providedIn: 'root'
})
export class CustomerService {
  customers: any[] = [];

  constructor() { }

  async addCustomer(dto: {firstName: any, lastName: any, email: any}){
    const httpResult = await customAxios.post<any>('Customer', dto);
    return httpResult.data;
  }

  async getCustomers(){
    const httpResponse = await customAxios.get<any>('Customer');
    this.customers =  httpResponse.data;
  }

  async getCustomerById(id: number){
    const httpResponse = await customAxios.get<any>('Customer/'+`${id}`);
    return httpResponse.data;
  }

  async updateCustomer(dto: {id: any, firstName: any, lastName: any, email: any}, id: number) {
    const httpResult = await customAxios.put('Customer/'+`${id}`, dto);
    return httpResult.data;
  }

  async deleteCustomer(id: any){
    const httpResult = await customAxios.delete('Customer/' + id);
    return httpResult.data;
  }
}
