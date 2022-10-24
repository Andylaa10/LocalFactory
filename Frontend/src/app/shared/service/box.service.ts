import { Injectable } from '@angular/core';
import axios from "axios";

export const customAxios =axios.create({
  //baseURL: 'https://localfactoryandy.azurewebsites.net'
  baseURL: 'https://localhost:7006'
});

@Injectable({
  providedIn: 'root'
})
export class BoxService {


  constructor() { }

  async addBox(dto: {boxName: any, description: any, price: any}){
    const httpResult = await customAxios.post<any>('Box', dto);
    return httpResult.data;
  }

  async getBoxes(){
    const httpResponse = await customAxios.get<any>('Box');
    return httpResponse.data;
  }

  async getBoxById(id: number){
    const httpResponse = await customAxios.get<any>('Box/'+`${id}`);
    return httpResponse.data;
  }

  async updateBox(dto: {id: any, boxName: any, description: any, price: any}, id: number) {
    const httpResult = await customAxios.put('Box/'+`${id}`, dto);
    return httpResult.data;
  }

  async deleteBox(id: any){
    const httpResult = await customAxios.delete('Box/' + id);
    return httpResult.data;
  }




}
