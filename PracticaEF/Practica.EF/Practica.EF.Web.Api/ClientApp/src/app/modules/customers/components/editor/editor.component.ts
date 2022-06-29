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

  customerID: string;
  companyName: string;
  contactName: string;
  contactTitle: string;
  address: string;
  city: string;
  region: string;
  postalCode: string;
  country: string;
  phone: string;
  fax: string;

  constructor(
    public dialogRef: MatDialogRef<EditorComponent>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData,
    private fb: FormBuilder
  ) { 
    this.customerID = data.CustomerID;
    this.companyName = data.CompanyName;
    this.contactName = data.ContactName;
    this.contactTitle = data.ContactTitle;
    this.address = data.Address;
    this.city = data.City;
    this.region = data.Region;
    this.postalCode = data.PostalCode;
    this.country = data.Country;
    this.phone = data.Phone;
    this.fax = data.Fax;
  }

  ngOnInit(): void {
    this.form = this.fb.group({
      CustomerID: new FormControl(this.customerID, [Validators.required, Validators.pattern(/^(\s+\S+\s*)*(?!\s).*$/)]),
      CompanyName: new FormControl(this.companyName, [Validators.required, Validators.pattern(/^(\s+\S+\s*)*(?!\s).*$/)]),
      ContactName: new FormControl(this.contactName, [Validators.required, Validators.pattern(/^(\s+\S+\s*)*(?!\s).*$/)]),
      ContactTitle: new FormControl(this.contactTitle),
      Address: new FormControl(this.address),
      City: new FormControl(this.city),
      Region: new FormControl(this.region),
      PostalCode: new FormControl(this.postalCode),
      Country: new FormControl(this.country),
      Phone: new FormControl(this.phone),
      Fax: new FormControl(this.fax),
    });
  }

  cancel(): void {
    this.dialogRef.close();
  }

  accept(): void{
    this.data.CustomerID = this.form.get('CustomerID')?.value;
    this.data.CompanyName = this.form.get('CompanyName')?.value;
    this.data.ContactName = this.form.get('ContactName')?.value;
    this.data.ContactTitle = this.form.get('ContactTitle')?.value;
    this.data.Address = this.form.get('Address')?.value;
    this.data.City = this.form.get('City')?.value;
    this.data.Region = this.form.get('Region')?.value;
    this.data.PostalCode = this.form.get('PostalCode')?.value;
    this.data.Country = this.form.get('Country')?.value;
    this.data.Phone = this.form.get('Phone')?.value;
    this.data.Fax = this.form.get('Fax')?.value;

    this.dialogRef.close(this.data);
  }

}

interface DialogData{
  CustomerID: string;
  CompanyName: string;
  ContactName: string;
  ContactTitle: string;
  Address: string;
  City: string;
  Region: string;
  PostalCode: string;
  Country: string;
  Phone: string;
  Fax: string;
}
