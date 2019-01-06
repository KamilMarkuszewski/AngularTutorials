import { Component } from '@angular/core';
import { Model, TodoItem } from "./model";

@Component({
  selector: 'todo-app',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'app';
  model = new Model();

  getName()
  {
    return this.model.user;
  }

  getTodoItems()
  {
    if(this.model.showAll)
    {
      return this.model.items;
    }
    else
    {
      return this.model.items.filter(i => !i.done);
    }
  }

  addItem(item)
  {
    if(item != "")
    {
      this.model.items.push(new TodoItem(item, false));
    }
  }
}
