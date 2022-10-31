import { Injectable } from '@angular/core';
import axios from "axios";

export const customAxios =axios.create({
  //baseURL: 'https://localfactoryandy.azurewebsites.net'
  baseURL: 'https://localhost:7006'
});

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  constructor() { }

  async addOrder(dto: {customerId: any, boxId: any}){
    const httpResult = await customAxios.post<any>('Order', dto);
    return httpResult.data;
  }

  async getOrders(){
    const httpResponse = await customAxios.get<any>('Order');
    return httpResponse.data;
  }

  async getOrderById(id: number){
    const httpResponse = await customAxios.get<any>('Order/'+`${id}`);
    return httpResponse.data;
  }

  async getCustomersOrder(customerId: number | undefined){
    const httpResponse = await customAxios.get<any>('Order/customer/'+`${customerId}`);
    return httpResponse.data;
  }

  async getBoxesOrder(boxId: number){
    const httpResponse = await customAxios.get<any>('Order/box/'+`${boxId}`);
    return httpResponse.data;
  }

  async deleteCustomer(id: any){
    const httpResult = await customAxios.delete('Order/' + id);
    return httpResult.data;
  }

}
