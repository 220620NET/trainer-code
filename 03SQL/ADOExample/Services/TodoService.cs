using Models;
using Repository;


/* 
    The service layers purpose is to do business logic

    "business logic" meaning the actual problem solving code you will have to right

 */
namespace Services
{
    public class TodoService
    {
        private TodoDAO todoDao = new TodoDAOImpl(); //upcasting

        public List<Todo> GetAllTodos(){
            return todoDao.GetAllTodos();
        }

        public bool CreateTodo(Todo todo){
            // since there isnt really business logic anywhere in this app, I made up a requirement that descriptions of todos can be only 10 characters long
            if(todo.description.Equals("")){
                return false;
            }
            
            
            if(todo.description.Length > 10){
                return false;
            }


            return todoDao.CreateTodo(todo);

        }

        public void DeleteOneTodo(int todoId){
            todoDao.DeleteOneTodo(todoId);
        }


    }
}