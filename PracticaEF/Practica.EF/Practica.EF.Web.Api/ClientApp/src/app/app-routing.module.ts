import { SkeletonComponent } from './layout/skeleton/skeleton.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path:'',
    component: SkeletonComponent,
    children:[
      {
        path: 'customers',
        loadChildren: () => import('./modules/customers/customers.module').then(m => m.CustomersModule)
      },
      {
        path: 'shippers',
        loadChildren: () => import('./modules/shippers/shippers.module').then(m => m.ShippersModule)
      }
    ]
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {useHash: true})],
  exports: [RouterModule]
})
export class AppRoutingModule { }
