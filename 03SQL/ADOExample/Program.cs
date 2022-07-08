using Sensitive;
using Repository;
using Models;
using Services;

TodoService todoService = new TodoService();

bool running = true;

do
{
    Console.WriteLine("TODO APP\n1) Print all todos\n2) Create A Todo\n3) Delete A Todo\n0) EXIT");

    string? input = Console.ReadLine();

    switch (input)
    {
        case "1":
            List<Todo> todos = todoService.GetAllTodos();
            Console.WriteLine($"Amount of Todos: {todos.Count()}");
            foreach (Todo todo in todos)
            {
                Console.WriteLine(todo);
            }
            break;
        case "2":
            //creating a todo
            Console.Write("Descripton of TODO: ");

            string? description = Console.ReadLine();
            bool isSuccessful = todoService.CreateTodo(new Todo(description));
            
            if(isSuccessful){
                Console.WriteLine("Todo Created");
            }else{
                Console.WriteLine("Todo Not Created");
            }
            break;
        case "3":
            //printing all todos to the console
            List<Todo> todolist = todoService.GetAllTodos();

            foreach (Todo todo in todolist)
            {
                Console.WriteLine(todo);
            }

            //requesting input for the todo id to delete
            Console.Write("Todo Id: ");

            if(Int32.TryParse(Console.ReadLine(), out int todoid)){
                todoService.DeleteOneTodo(todoid);
            }else{
                Console.WriteLine("Invalid Input");
            }
            break;
        case "0":
            //exit
            running = false;
            break;
        default:
            Console.WriteLine("Invalid Input");
            break;
    }

} while (running);

