import { Injectable } from '@angular/core';
import { Employee } from '../models/Employee';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class EmployeeService {
  endpoint: string = 'http://localhost:4000/users';
  constructor(private http: HttpClient) {}

  addEmployee(employee: Employee): Observable<any> {
    // let api = `${this.endpoint}`
    return this.http
      .post(this.endpoint, employee)
      .pipe(catchError(this.handleError));
  }

  getEmployee(): Observable<any> {
    return this.http.get(this.endpoint).pipe(catchError(this.handleError));
  }

  getEmployeeById(employee: Employee): Observable<any> {
    const api = `${this.endpoint}/${employee.id}`;
    return this.http.get(api).pipe(catchError(this.handleError));
  }

  updateEmployee(id: number, employee: Employee): Observable<any> {
    const api = `${this.endpoint}/${id}`;
    return this.http.put(api, employee).pipe(catchError(this.handleError));
  }

  deleteEmployee(id: number): Observable<any> {
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
