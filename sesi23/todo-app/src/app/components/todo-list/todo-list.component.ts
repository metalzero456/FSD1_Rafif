import { Component, OnInit } from '@angular/core';
import { Todo } from 'src/app/models/Todo';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css'],
})
export class TodoListComponent implements OnInit {
  todos: Todo[] = [];

  ngOnInit(): void {
    this.todos = [];
  }

  toggleDone(id: number) {
    this.todos.map((v, i) => {
      if (i == id) v.completed = !v.completed;
      console.log(v);
      return v;
    });
  }

  addTodo(todo: Todo) {
    this.todos.push(todo);
  }

  editTodo(id: number, todo: any) {
    this.todos[id].content = todo.content;
    this.todos[id].editing = false;
  }

  deleteTodo(id: number) {
    this.todos = this.todos.filter((v, i) => i !== id);
  }

  changeStatus(id: number) {
    this.todos[id].editing = true;
  }
}
