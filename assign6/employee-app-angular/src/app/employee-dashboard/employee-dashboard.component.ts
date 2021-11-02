import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../services/employee.service';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import {
  AbstractControl,
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { matchValidator } from './validation';
import { Employee } from '../models/Employee';

@Component({
  selector: 'app-employee-dashboard',
  templateUrl: './employee-dashboard.component.html',
  styleUrls: ['./employee-dashboard.component.css'],
})
export class EmployeeDashboardComponent implements OnInit {
  closeResult: string = '';

  editedIndex: number = 0;

  employees: Employee[] = [];

  addEmployeeForm = new FormGroup({
    title: new FormControl('', [Validators.required]),
    firstName: new FormControl('', [Validators.required]),
    lastName: new FormControl('', [Validators.required]),
    email: new FormControl('', [Validators.required, Validators.email]),
    role: new FormControl('', [Validators.required]),
    password: new FormControl('', [
      Validators.required,
      Validators.minLength(5),
    ]),
    confirmPassword: new FormControl('', [
      Validators.required,
      Validators.minLength(5),
      matchValidator('password'),
    ]),
  });

  editEmployeeForm = new FormGroup({
    title: new FormControl('', [Validators.required]),
    firstName: new FormControl('', [Validators.required]),
    lastName: new FormControl('', [Validators.required]),
    email: new FormControl('', [Validators.required, Validators.email]),
    role: new FormControl('', [Validators.required]),
  });

  constructor(
    private modalService: NgbModal,
    public employeeService: EmployeeService
  ) {}

  ngOnInit(): void {
    this.refreshData();
  }

  refreshData() {
    this.employeeService.getEmployee().subscribe((data: any[]) => {
      this.employees = data;
    });
  }

  get title() {
    return this.addEmployeeForm.get('title');
  }

  get firstName() {
    return this.addEmployeeForm.get('firstName');
  }

  get lastName() {
    return this.addEmployeeForm.get('lastName');
  }

  get email() {
    return this.addEmployeeForm.get('email');
  }

  get role() {
    return this.addEmployeeForm.get('role');
  }

  get password() {
    return this.addEmployeeForm.get('password');
  }

  get confirmPassword() {
    return this.addEmployeeForm.get('confirmPassword');
  }

  setEditedIndex(id: number) {
    this.editedIndex = id;
  }

  addEmployee() {
    this.employeeService
      .addEmployee(this.addEmployeeForm.value)
      .subscribe((res) => {
        this.addEmployeeForm.reset();
        this.refreshData();
      });
  }

  editEmployee(id: number) {
    this.employeeService
      .updateEmployee(id, this.editEmployeeForm.value)
      .subscribe((res) => {
        this.editEmployeeForm.reset();
        this.refreshData();
      });
  }

  deleteEmployee(id: number) {
    this.employeeService.deleteEmployee(id).subscribe((res) => {
      this.refreshData();
    });
  }

  open(content: any) {
    this.modalService
      .open(content, { ariaLabelledBy: 'modal-basic-title' })
      .result.then(
        (result) => {
          this.closeResult = `Closed with: ${result}`;
        },
        (reason) => {
          this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
        }
      );
  }

  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return `with: ${reason}`;
    }
  }
}
