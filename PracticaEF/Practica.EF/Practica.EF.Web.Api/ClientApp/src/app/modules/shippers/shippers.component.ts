import { Component, OnInit } from '@angular/core';
import { Shipper } from './models/shipper';
import { ShippersService } from './services/shippers.service';
import { MatTableDataSource } from '@angular/material/table';
import { MatDialog } from '@angular/material/dialog';
import { EditorComponent } from './components/editor/editor.component';

@Component({
  selector: 'app-shippers',
  templateUrl: './shippers.component.html',
  styleUrls: ['./shippers.component.css']
})
export class ShippersComponent implements OnInit {

  public shippersGrid: Shipper[];

  displayedColumns: string[] = [ 'ShipperID', 'CompanyName', 'Phone', 'buttons' ];
  dataSource: any;

  constructor(
    private shippersService: ShippersService,
    public dialog: MatDialog
    ) { 
    this.shippersGrid = [];
  }

  ngOnInit(): void {
    this.loadGrid();
  }

  loadGrid(): void{
    this.shippersService.GetAll().subscribe((shippers)=>{
      this.shippersGrid = shippers;

      this.dataSource = new MatTableDataSource<Shipper>(this.shippersGrid);
    });
  }

  editShipper(shipperID: string, companyName: string, phone: string): void{
    const dialogRef = this.dialog.open(EditorComponent, {
      width: '250px',
      data: { ShipperID: shipperID, CompanyName: companyName, Phone: phone }
    });

    dialogRef.afterClosed().subscribe(data => {
      console.log('The dialog was closed');

      if(data !== undefined){
        let shipper: Shipper = new Shipper(data.ShipperID, data.CompanyName, data.Phone);

        this.shippersService.Update(shipper).subscribe((res) =>{
          this.loadGrid();
        },
        (e)=>{
          console.log(e);
          alert(JSON.stringify(e));
        });
      }
    });
  }

  deleteShipper(shipperID: string): void{
    
  }

}
