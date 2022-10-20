import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class BoxService {
  // Handle data
  apiUrl = 'https://localfactoryandy.azurewebsites.net/Box';

  constructor(private http: HttpClient) { }

  addBox(box: any): Observable<any>{
    return this.http.post<any>(this.apiUrl, box)
  }

  getBoxes(): Observable<any[]>{
    return this.http.get<any[]>(this.apiUrl);
  }

  getBoxById(id: number): Observable<any>{
    return this.http.get<any>(`${this.apiUrl}/${id}`)
  }

  updateBox(box: any, id: number): Observable<any>{
    return this.http.put<any>(`${this.apiUrl}/${id}`, box)
  }

  deleteBox(id: number): Observable<any>{
    return this.http.delete<any>(`${this.apiUrl}/${id}`)
  }



}
