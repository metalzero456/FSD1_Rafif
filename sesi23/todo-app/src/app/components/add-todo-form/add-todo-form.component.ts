import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { Todo } from 'src/app/models/Todo';

@Component({
  selector: 'app-add-todo-form',
  templateUrl: './add-todo-form.component.html',
  styleUrls: ['./add-todo-form.component.css'],
})
export class AddTodoFormComponent implements OnInit {
  @Output() addTodoEvent = new EventEmitter<Todo>();

  inputTodo: string = '';

  addTodo() {
    const todo: Todo = {
      content: this.inputTodo,
      completed: false,
    };

    this.addTodoEvent.emit(todo);
    this.inputTodo = '';
  }
  constructor() {}

  ngOnInit(): void {}
}
