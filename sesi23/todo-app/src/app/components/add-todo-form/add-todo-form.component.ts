import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { Todo } from 'src/app/models/Todo';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-todo-form',
  templateUrl: './add-todo-form.component.html',
  styleUrls: ['./add-todo-form.component.css'],
})
export class AddTodoFormComponent implements OnInit {
  @Output() addTodoEvent = new EventEmitter<Todo>();

  errors = { todo: {} };
  inputTodo: string = '';
  isSubmitted: boolean = false;

  todoData = new FormGroup({
    todo: new FormControl('', [
      Validators.required,
      Validators.minLength(3),
      Validators.maxLength(100),
    ]),
  });

  get todo() {
    return this.todoData.get('todo');
  }

  addTodo() {
    const todo: Todo = {
      content: this.inputTodo,
      completed: false,
    };
    this.addTodoEvent.emit(todo);
    this.inputTodo = '';
  }

  isValidate() {
    if (this.todo?.invalid) {
      this.errors.todo = { ...this.todo?.errors };
    } else {
      this.addTodo();
      this.errors.todo = {};
      this.handleIsSubmittedState();
    }
  }

  handleTodoForm() {
    console.log('this works too');
    this.isSubmitted = true;
    this.isValidate();
  }

  handleIsSubmittedState() {
    if (this.isSubmitted == true) {
      console.log('this works');
      this.isSubmitted = false;
    }
  }

  constructor() {}

  ngOnInit(): void {}
}
