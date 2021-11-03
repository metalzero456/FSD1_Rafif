import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MAT_DATE_FORMATS } from '@angular/material/core';
import { PaymentService } from 'src/app/services/payment.service';
import { Router } from '@angular/router';

export const MY_DATE_FORMATS = {
  parse: {
    dateInput: 'MM/YY',
  },
  display: {
    dateInput: 'MM/YY',
    monthYearLabel: 'MMMM YYYY',
    dateA11yLabel: 'LL',
    monthYearA11yLabel: 'MMMM YYYY',
  },
};

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
  providers: [{ provide: MAT_DATE_FORMATS, useValue: MY_DATE_FORMATS }],
})
export class RegisterComponent implements OnInit {
  addPaymentForm = new FormGroup({
    cardOwnerName: new FormControl('', [Validators.required]),
    cardNumber: new FormControl('', [
      Validators.required,
      Validators.maxLength(16),
      Validators.pattern('^[0-9]*$'),
    ]),
    expirationDate: new FormControl('', [Validators.required]),
    securityCode: new FormControl('', [
      Validators.required,
      Validators.minLength(6),
      Validators.maxLength(6),
      Validators.pattern('^[0-9]*$'),
    ]),
  });
  constructor(public paymentService: PaymentService, public router: Router) {}

  ngOnInit(): void {}

  addPayment() {
    this.paymentService
      .addPayment(this.addPaymentForm.value)
      .subscribe((res) => {
        this.addPaymentForm.reset();
        this.router.navigate(['home']);
      });
  }

  getErrorMessageOwner() {
    if (this.addPaymentForm.get('cardOwnerName')?.hasError('required')) {
      return 'Card Owner Name is Required';
    } else return '';
  }

  getErrorMessageNumber() {
    if (this.addPaymentForm.get('cardNumber')?.hasError('pattern')) {
      return 'Please input only numeric value';
    }
    if (this.addPaymentForm.get('cardNumber')?.hasError('required')) {
      return 'Card Number is Required';
    } else return 'Exceeded Card Number Length of 16 digits';
  }

  getErrorMessageSecurity() {
    if (this.addPaymentForm.get('securityCode')?.hasError('pattern')) {
      return 'Please input only numeric value';
    }
    if (this.addPaymentForm.get('securityCode')?.hasError('required')) {
      return 'Security Code is Required';
    } else if (this.addPaymentForm.get('securityCode')?.hasError('minlength')) {
      return 'Security Code Length must be 6 digits';
    } else return 'Exceeded Security Code Length of 6 digits';
  }

  getErrorMessageDate() {
    if (this.addPaymentForm.get('expirationDate')?.hasError('required')) {
      return 'Expiration Date is Required';
    } else return '';
  }
}
