import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';

@Component({
  selector: 'app-editor',
  templateUrl: './editor.component.html',
  styleUrls: ['./editor.component.css']
})
export class EditorComponent implements OnInit {
  shipperID: string;
  companyName: string;
  phone: string;

  constructor(
    public dialogRef: MatDialogRef<EditorComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData
  ) { 
    this.shipperID = data.ShipperID;
    this.companyName = data.CompanyName;
    this.phone = data.Phone;
  }

  ngOnInit(): void {
  }

  cancel(): void {
    this.dialogRef.close();
  }
}

export interface DialogData {
  ShipperID: string,
  CompanyName: string;
  Phone: string;
}
