import { Component, OnInit, Inject } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MAT_DATE_FORMATS } from '@angular/material/core';
import { PaymentService } from 'src/app/services/payment.service';

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
  selector: 'app-update-dialog',
  templateUrl: './update-dialog.component.html',
  styleUrls: ['./update-dialog.component.css'],
  providers: [{ provide: MAT_DATE_FORMATS, useValue: MY_DATE_FORMATS }],
})
export class UpdateDialogComponent implements OnInit {
  updatePaymentForm = new FormGroup({
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
  constructor(
    @Inject(MAT_DIALOG_DATA) public data: any,
    public paymentService: PaymentService
  ) {}

  ngOnInit(): void {}

  updatePayment(id: number) {
    console.log(this.updatePaymentForm.get('expirationDate')?.value);
    this.paymentService
      .updatePayment(id, this.updatePaymentForm.value)
      .subscribe((res) => {
        this.updatePaymentForm.reset();
        window.location.reload();
      });
  }

  getErrorMessageOwner() {
    if (this.updatePaymentForm.get('cardOwnerName')?.hasError('required')) {
      return 'Card Owner Name is Required';
    } else return '';
  }

  getErrorMessageNumber() {
    if (this.updatePaymentForm.get('cardNumber')?.hasError('pattern')) {
      return 'Please input only numeric value';
    }
    if (this.updatePaymentForm.get('cardNumber')?.hasError('required')) {
      return 'Card Number is Required';
    } else return 'Exceeded Card Number Length of 16 digits';
  }

  getErrorMessageSecurity() {
    if (this.updatePaymentForm.get('securityCode')?.hasError('pattern')) {
      return 'Please input only numeric value';
    }
    if (this.updatePaymentForm.get('securityCode')?.hasError('required')) {
      return 'Security Code is Required';
    } else if (
      this.updatePaymentForm.get('securityCode')?.hasError('minlength')
    ) {
      return 'Security Code Length must be 6 digits';
    } else return 'Exceeded Security Code Length of 6 digits';
  }

  getErrorMessageDate() {
    if (this.updatePaymentForm.get('expirationDate')?.hasError('required')) {
      return 'Expiration Date is Required';
    } else return '';
  }
}
