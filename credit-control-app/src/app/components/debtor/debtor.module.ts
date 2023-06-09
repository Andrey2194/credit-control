import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DebtorRoutingModule } from './debtor-routing.module';
import { DebtorComponent } from './debtor.component';


@NgModule({
  declarations: [DebtorComponent],
  imports: [
    CommonModule,
    DebtorRoutingModule
  ]
})
export class DebtorModule { }
