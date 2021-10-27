import { Component, Output, EventEmitter, OnInit, Input } from '@angular/core';
import { Todo } from 'src/app/models/Todo';

@Component({
  selector: 'app-edit-todo-form',
  templateUrl: './edit-todo-form.component.html',
  styleUrls: ['./edit-todo-form.component.css'],
})
export class EditTodoFormComponent implements OnInit {
  @Input() message = '';
  @Output() editTodoEvent = new EventEmitter<Todo>();
  todoText: string = this.message;

  editTodo() {
    const todo: Todo = {
      content: this.todoText,
      completed: false,
    };
    this.editTodoEvent.emit(todo);
    this.todoText = '';
  }

  constructor() {}

  ngOnInit(): void {}
}
