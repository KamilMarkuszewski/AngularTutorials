
export class Model
{
    user;
    items;

    constructor() {        
        this.user = "Username";
        this.items = 
        [
            new TodoItem("Task 1", false),
            new TodoItem("Task 2", false),
            new TodoItem("Task 3", true),
            new TodoItem("Task 4", true)
        ];
    }
}

export class TodoItem
{
    action;
    done;

    constructor(action, done) {
        this.action = action;
        this.done = done;
    }
}
