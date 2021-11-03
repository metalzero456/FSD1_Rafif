import {
  Component,
  Input,
  OnInit,
  Output,
  EventEmitter,
  ViewChild,
} from '@angular/core';
import { Payment } from 'src/app/models/payment';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { DeleteDialogComponent } from '../delete-dialog/delete-dialog.component';
import { UpdateDialogComponent } from '../update-dialog/update-dialog.component';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css'],
})
export class TableComponent implements OnInit {
  @Input() set paymentData(value: Payment[]) {
    this.dataSource = new MatTableDataSource<Payment>(value);
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
  }

  @Output() refreshDataEvent = new EventEmitter<boolean>();

  @ViewChild(MatPaginator)
  paginator!: MatPaginator;

  @ViewChild(MatSort)
  sort!: MatSort;

  displayedColumns: string[] = [
    'paymentId',
    'cardOwnerName',
    'cardNumber',
    'expirationDate',
    'action',
  ];
  dataSource!: MatTableDataSource<Payment>;

  constructor(public dialog: MatDialog) {}

  ngOnInit(): void {}

  ngAfterViewInit() {}

  applyFilter(event: any) {
    const targetValue = event.target.value;
    this.dataSource.filter = targetValue.trim().toLowerCase();
  }

  openDeleteDialog(payment: Payment) {
    const dialogRef = this.dialog.open(DeleteDialogComponent, {
      data: payment,
    });
    dialogRef.afterClosed().subscribe((res) => {
      this.refreshDataEvent.emit(res);
    });
  }

  openUpdateDialog(payment: Payment) {
    const dialogRef = this.dialog.open(UpdateDialogComponent, {
      data: payment,
    });
    dialogRef.afterClosed().subscribe((res) => {
      this.refreshDataEvent.emit(res);
    });
  }
}
