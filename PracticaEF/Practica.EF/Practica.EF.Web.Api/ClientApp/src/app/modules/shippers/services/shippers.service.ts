import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Shipper } from '../models/shipper';

@Injectable({
  providedIn: 'root'
})
export class ShippersService {

  constructor(private http: HttpClient) { }

  GetAll(): Observable<any>{
    let endpoint: string = 'api/Shippers';
    
    return this.http.get(environment.apiUrl + endpoint);
  }

  Update(shipper: Shipper): Observable<any>{
    let endpoint: string = 'api/Shippers/' + shipper.ShipperID;
    
    return this.http.put(environment.apiUrl + endpoint, shipper);
  }
}
