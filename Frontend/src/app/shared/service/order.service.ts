import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class OrderService {
  // Handle data
  apiUrl = 'https://localfactoryandy.azurewebsites.net/Order';

  constructor() { }
}
