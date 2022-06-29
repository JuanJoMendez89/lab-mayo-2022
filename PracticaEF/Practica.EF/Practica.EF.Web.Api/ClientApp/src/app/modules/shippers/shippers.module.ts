import { ShippersComponent } from './shippers.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { ShippersRoutingModule } from './shippers-routing.module';

import { MatTableModule } from '@angular/material/table';
import { MatIconModule } from '@angular/material/icon';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatDialogModule } from '@angular/material/dialog';

import { EditorComponent } from './components/editor/editor.component';

@NgModule({
  declarations: [
    ShippersComponent,
    EditorComponent
  ],
  imports: [
    CommonModule,
    ShippersRoutingModule,
    MatTableModule,
    MatIconModule,
    MatFormFieldModule,
    MatInputModule,
    FormsModule,
    MatDialogModule
  ]
})
export class ShippersModule { }
