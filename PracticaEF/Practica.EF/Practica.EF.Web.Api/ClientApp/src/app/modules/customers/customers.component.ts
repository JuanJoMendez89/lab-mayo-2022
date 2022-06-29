import { Component, OnInit } from '@angular/core';
import { Customer } from './models/customer';
import { CustomersService } from './services/customers.service';
import { MatTableDataSource } from '@angular/material/table';
import { MatDialog } from '@angular/material/dialog';
import { EditorComponent } from './components/editor/editor.component';
import { ConfirmDialogComponent } from 'src/app/shared/components/confirm-dialog/confirm-dialog.component';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent implements OnInit {
  public customersGrid: Customer[];

  displayedColumns: string[] = [ 'CustomerID', 'CompanyName', 'ContactName', 'ContactTitle', 'buttons' ];
  dataSource: any;

  constructor(
    private customersService: CustomersService,
    public dialog: MatDialog
    ) { 
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

  addCustomer(): void{
    const dialogRef = this.dialog.open(EditorComponent, {
      width: '250px',
      data: { 
        CustomerID: "",
        CompanyName: "",
        ContactName: "",
        ContactTitle: "",
        Address: "",
        City: "",
        Region: "",
        PostalCode: "",
        Country: "",
        Phone: "",
        Fax: "",
      }
    });

    dialogRef.afterClosed().subscribe(data => {
      if(data !== undefined){
        let customer: Customer = new Customer(
          data.CustomerID,
          data.CompanyName,
          data.ContactName,
          data.ContactTitle,
          data.Address,
          data.City,
          data.Region,
          data.PostalCode,
          data.Country,
          data.Phone,
          data.Fax
          );

        this.customersService.Add(customer).subscribe((res) =>{
          this.loadGrid();
        },
        (e)=>{
          console.log(e);
          alert("Ocurrió un error");
        });
      }
    });
  }

  editCustomer(customer: Customer): void{
    const dialogRef = this.dialog.open(EditorComponent, {
      width: '250px',
      data: { 
        CustomerID: customer.CustomerID,
        CompanyName: customer.CompanyName,
        ContactName: customer.ContactName,
        ContactTitle: customer.ContactTitle,
        Address: customer.Address,
        City: customer.City,
        Region: customer.Region,
        PostalCode: customer.PostalCode,
        Country: customer.Country,
        Phone: customer.Phone,
        Fax: customer.Fax,
      }
    });

    dialogRef.afterClosed().subscribe(data => {
      if(data !== undefined){
        let customer: Customer = new Customer(
          data.CustomerID,
          data.CompanyName,
          data.ContactName,
          data.ContactTitle,
          data.Address,
          data.City,
          data.Region,
          data.PostalCode,
          data.Country,
          data.Phone,
          data.Fax
          );

        this.customersService.Update(customer).subscribe((res) =>{
          this.loadGrid();
        },
        (e)=>{
          console.log(e);
          alert("Ocurrió un error");
        });
      }
    });
  }

  deleteCustomer(customerID: number, contactName: string): void{
    const confirmRef = this.dialog.open(ConfirmDialogComponent, {
      width: '250px',
      data: { Title: `Delete customer: ${contactName}`, Message: 'Are you sure you want to delete this customer?'}
    });

    confirmRef.afterClosed().subscribe(data => {
      console.log(data)
      if(data !== undefined){
        this.customersService.Delete(customerID).subscribe((res) =>{
          this.loadGrid();
        },
        (e)=>{
          if(e.error.Message !== undefined) alert(e.error.Message);
          else alert('An error has ocurred');
        });

      }
    });
  }

}
