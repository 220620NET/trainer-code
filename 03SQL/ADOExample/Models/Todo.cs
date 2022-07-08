/* 
    Our models will hold the data that we want to pass around our application
 */
namespace Models
{
    public class Todo
    {
        public int id{ get; set; }
        public string description{get; set;}
        public bool isComplete{get; set;}

        public Todo(string description = ""){
            this.description = description;
        }

        public Todo(int id, string description, bool isComplete){
            this.id = id;
            this.description = description;
            this.isComplete = isComplete;
        }


        public override string ToString()
        {
            return "id: " + this.id +
            ", description: " + this.description +
            ", isComplete: " + this.isComplete;
        }

    }
}