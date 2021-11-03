import { Component, OnInit, Inject } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { PaymentService } from 'src/app/services/payment.service';

@Component({
  selector: 'app-delete-dialog',
  templateUrl: './delete-dialog.component.html',
  styleUrls: ['./delete-dialog.component.css'],
})
export class DeleteDialogComponent implements OnInit {
  constructor(
    @Inject(MAT_DIALOG_DATA) public data: any,
    public paymentService: PaymentService
  ) {}

  ngOnInit(): void {}

  deletePayment(id: number) {
    this.paymentService.deletePayment(id).subscribe((res) => {
      window.location.reload();
    });
  }
}
