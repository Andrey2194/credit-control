import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DebtorComponent } from './debtor.component';

const routes: Routes = [
  {
    path:'',
    component: DebtorComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DebtorRoutingModule { }
