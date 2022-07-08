using Models;

namespace Repository
{
    public interface TodoDAO
    {
        public List<Todo> GetAllTodos();
        public bool CreateTodo(Todo todo);
        public void DeleteOneTodo(int todoId);
    }
}