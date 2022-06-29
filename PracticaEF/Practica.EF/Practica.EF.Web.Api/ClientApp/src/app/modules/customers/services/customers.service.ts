import { environment } from '../../../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CustomersService {

  constructor(private http: HttpClient) { }

  GetAll(): Observable<any>{
    let endpoint: string = 'api/Customers';
    
    return this.http.get(environment.apiUrl + endpoint);
  }
}
