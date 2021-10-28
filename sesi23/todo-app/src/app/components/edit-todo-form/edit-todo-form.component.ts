import { Component, Output, EventEmitter, OnInit, Input } from '@angular/core';
import { Todo } from 'src/app/models/Todo';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-edit-todo-form',
  templateUrl: './edit-todo-form.component.html',
  styleUrls: ['./edit-todo-form.component.css'],
})
export class EditTodoFormComponent implements OnInit {
  @Input() message = '';
  @Output() editTodoEvent = new EventEmitter<Todo>();

  errors = { todo: {} };
  isSubmitted: boolean = false;

  todoData = new FormGroup({
    todo: new FormControl('', [Validators.required, Validators.minLength(3)]),
  });

  get todo() {
    return this.todoData.get('todo');
  }

  editTodo() {
    const todo: Todo = {
      content: this.message,
      completed: false,
    };
    this.editTodoEvent.emit(todo);
    this.message = '';
  }

  isValidate() {
    if (this.todo?.invalid) {
      this.errors.todo = { ...this.todo?.errors };
    } else {
      this.editTodo();
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
