import { CustomerquotationComponent } from './customerquotation/customerquotation.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SalesVoucherComponent } from './sales-voucher/sales-voucher.component';


const routes: Routes = [
  {
    path: 'customerquotation',
    component: CustomerquotationComponent,
    data: { title: 'Customer Quotation', titleI18n: 'Customer Quotation' }
  },
  {
    path: 'salesvoucher',
    component: SalesVoucherComponent,
    data: { title: 'Sales Voucher', titleI18n: 'Sales Voucher' }
  }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SaleRoutingModule { }
