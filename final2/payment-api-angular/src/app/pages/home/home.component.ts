import { Component, OnInit } from '@angular/core';
import { PaymentService } from 'src/app/services/payment.service';
import { Payment } from 'src/app/models/payment';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent implements OnInit {
  payments: Payment[] = [];

  constructor(public paymentService: PaymentService, public router: Router) {}

  ngOnInit(): void {
    this.refreshData();
  }

  refreshData() {
    this.paymentService.getPayments().subscribe((data: any[]) => {
      this.payments = data;
      console.log(data);
    });
    console.log('Data refreshed');
  }

  checkRefresh(value: boolean) {
    if (value) {
      this.refreshData();
    } else {
      console.log('not executed');
    }
  }
}
