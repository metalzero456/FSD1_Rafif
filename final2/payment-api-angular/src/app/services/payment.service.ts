import { Injectable } from '@angular/core';
import { Payment } from '../models/payment';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class PaymentService {
  endpoint: string = 'http://paymentapi-rafif.herokuapp.com/payment';

  constructor(private http: HttpClient) {}

  getPayments(): Observable<any> {
    return this.http.get(this.endpoint).pipe(catchError(this.handleError));
  }

  addPayment(payment: Payment): Observable<any> {
    return this.http
      .post(this.endpoint, payment)
      .pipe(catchError(this.handleError));
  }

  updatePayment(id: number, payment: Payment): Observable<any> {
    const api = `${this.endpoint}/${id}`;
    return this.http.put(api, payment).pipe(catchError(this.handleError));
  }

  deletePayment(id: number): Observable<any> {
    const api = `${this.endpoint}/${id}`;
    return this.http.delete(api).pipe(catchError(this.handleError));
  }

  handleError(err: HttpErrorResponse) {
    let msg = '';
    if (err.error instanceof ErrorEvent) {
      msg = err.error.message;
    } else {
      msg = `Error Code: ${err.status}\nMessage: ${err.message}`;
    }
    return throwError(msg);
  }
}
