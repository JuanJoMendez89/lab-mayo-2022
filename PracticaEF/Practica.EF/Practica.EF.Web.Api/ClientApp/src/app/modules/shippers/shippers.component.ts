import { Component, OnInit } from '@angular/core';
import { Shipper } from './models/shipper';
import { ShippersService } from './services/shippers.service';
import { MatTableDataSource } from '@angular/material/table';
import { MatDialog } from '@angular/material/dialog';
import { EditorComponent } from './components/editor/editor.component';
import { ConfirmDialogComponent } from 'src/app/shared/components/confirm-dialog/confirm-dialog.component';

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

  addShipper(): void{
    const dialogRef = this.dialog.open(EditorComponent, {
      width: '250px',
      data: { ShipperID: 0, CompanyName: "", Phone: "" }
    });

    dialogRef.afterClosed().subscribe(data => {
      if(data !== undefined){
        let shipper: Shipper = new Shipper(data.ShipperID, data.CompanyName, data.Phone);

        this.shippersService.Add(shipper).subscribe((res) =>{
          this.loadGrid();
        },
        (e)=>{
          console.log(e);
          alert("Ocurrió un error");
        });
      }
    });
  }

  editShipper(shipper: Shipper): void{
    const dialogRef = this.dialog.open(EditorComponent, {
      width: '250px',
      data: { ShipperID: shipper.ShipperID, CompanyName: shipper.CompanyName, Phone: shipper.Phone }
    });

    dialogRef.afterClosed().subscribe(data => {
      if(data !== undefined){
        let shipper: Shipper = new Shipper(data.ShipperID, data.CompanyName, data.Phone);

        this.shippersService.Update(shipper).subscribe((res) =>{
          this.loadGrid();
        },
        (e)=>{
          console.log(e);
          alert("Ocurrió un error");
        });
      }
    });
  }

  deleteShipper(shipperID: number, companyName: string): void{
    const confirmRef = this.dialog.open(ConfirmDialogComponent, {
      width: '250px',
      data: { Title: `Delete shipper: ${companyName}`, Message: 'Are you sure you want to delete this shipper?'}
    });

    confirmRef.afterClosed().subscribe(data => {
      console.log(data)
      if(data !== undefined){
        this.shippersService.Delete(shipperID).subscribe((res) =>{
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
