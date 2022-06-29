import { environment } from '../../../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { Customer } from '../models/customer';

@Injectable({
  providedIn: 'root'
})
export class CustomersService {

  constructor(private http: HttpClient) { }

  GetAll(): Observable<any>{
    let endpoint: string = 'api/Customers';
    
    return this.http.get(environment.apiUrl + endpoint);
  }

  Add(customer: Customer): Observable<any>{
    let endpoint: string = 'api/Customers';
    
    return this.http.post(environment.apiUrl + endpoint, customer);
  }

  Update(customer: Customer): Observable<any>{
    let endpoint: string = 'api/Customers/' + customer.CustomerID;
    
    return this.http.put(environment.apiUrl + endpoint, customer);
  }

  Delete(CustomerID: number): Observable<any>{
    let endpoint: string = 'api/Customers/' + CustomerID;
    
    return this.http.delete(environment.apiUrl + endpoint);
  }
}
