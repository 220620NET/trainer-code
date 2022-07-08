using Models;
using System.Data.SqlClient;
using Sensitive;
/* 
    What is the DAO layer for?
        - the DAO layers purpose is to execute the SQL statements to the database

 */
namespace Repository
{
    public class TodoDAOImpl : TodoDAO
    {
         //we need the connectionstring from azure
        string connectionString = "Server=tcp:kevincserver.database.windows.net,1433;Initial Catalog=kevindatabase;Persist Security Info=False;User ID=sqluser;Password=" + SensitiveVariables.dbpassword  + ";MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public List<Todo> GetAllTodos(){

            List<Todo> todos = new List<Todo>();
           
            //this defines the sql operation we would like to do
            string sql = "select * from todoapp.todos;";

            //datatype for an active connection
            SqlConnection connection = new SqlConnection(connectionString);

            //datatype to reference the sql command you want to do to a specific connection
            SqlCommand command = new SqlCommand(sql, connection);

            try
            {
                //opening the connection to the database
                connection.Open();

                //storing the result set of a DQL statement into a variable
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read()){
                    todos.Add(new Todo((int) reader[0], (string) reader[1], (bool) reader[2]));
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return todos;
        }

        public bool CreateTodo(Todo todo){
            //this defines the sql operation we would like to do
            string sql = "insert into todoapp.todos (description) values (@description);";

            //datatype for an active connection
            SqlConnection connection = new SqlConnection(connectionString);

            //datatype to reference the sql command you want to do to a specific connection
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@description", todo.description); 
            //command.Parameters.AddWithValue("@name", "steve");

            try
            {
                //opening the connection to the database
                connection.Open();

                //storing the result set of a DQL statement into a variable

                //execute non query will be for DML statements
                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();

                if(rowsAffected != 0){
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return false;
        }

        public void DeleteOneTodo(int todoId){
            //this defines the sql operation we would like to do
            string sql = "delete from todoapp.todos where id = @todoId;";

            //datatype for an active connection
            SqlConnection connection = new SqlConnection(connectionString);

            //datatype to reference the sql command you want to do to a specific connection
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@todoId", todoId); 
            //command.Parameters.AddWithValue("@name", "steve");

            try
            {
                //opening the connection to the database
                connection.Open();

                //storing the result set of a DQL statement into a variable

                //execute non query will be for DML statements
                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void WhatsUp(){
            
        }

    }
}