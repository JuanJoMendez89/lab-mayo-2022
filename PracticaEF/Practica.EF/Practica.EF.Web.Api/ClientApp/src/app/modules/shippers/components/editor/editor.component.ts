import { Component, OnInit, Inject } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';

@Component({
  selector: 'app-editor',
  templateUrl: './editor.component.html',
  styleUrls: ['./editor.component.css']
})
export class EditorComponent implements OnInit {
  form!: FormGroup;

  shipperID: string;
  companyName: string;
  phone: string;

  constructor(
    public dialogRef: MatDialogRef<EditorComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData,
    private fb: FormBuilder
  ) { 
    this.shipperID = data.ShipperID;
    this.companyName = data.CompanyName;
    this.phone = data.Phone;
  }

  ngOnInit(): void {
    this.form = this.fb.group({
      CompanyName: new FormControl(this.companyName, [Validators.required, Validators.pattern(/^(\s+\S+\s*)*(?!\s).*$/)]),
      Phone: new FormControl(this.phone),
    });
  }

  cancel(): void {
    this.dialogRef.close();
  }

  accept(): void{
    this.data.CompanyName = this.form.get('CompanyName')?.value;
    this.data.Phone = this.form.get('Phone')?.value;

    this.dialogRef.close(this.data);
  }
}

export interface DialogData {
  ShipperID: string,
  CompanyName: string;
  Phone: string;
}
