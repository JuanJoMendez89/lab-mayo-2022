import { Component, OnInit } from '@angular/core';
import { Customer } from './models/customer';
import { CustomersService } from './services/customers.service';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent implements OnInit {
  public customersGrid: Customer[];

  displayedColumns: string[] = [ 'CustomerID', 'CompanyName', 'ContactName', 'ContactTitle', 'buttons' ];
  dataSource: any;

  constructor(private customersService: CustomersService) { 
    this.customersGrid = [];
  }

  ngOnInit(): void {
    this.loadGrid();
  }

  loadGrid(): void{
    this.customersService.GetAll().subscribe((customers)=>{
      this.customersGrid = customers;

      this.dataSource = new MatTableDataSource<Customer>(this.customersGrid);
    });
  }

  editCustomer(customerID: string): void{

  }

  deleteCustomer(customerID: string): void{
    
  }

}
