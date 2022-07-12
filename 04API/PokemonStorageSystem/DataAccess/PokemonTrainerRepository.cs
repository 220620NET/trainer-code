using Models;
using Microsoft.Data.SqlClient;

namespace DataAccess;

public class PokemonTrainerRepository : IPokemonTrainerRepository
{
    private readonly ConnectionFactory _connectionFactory;
    public PokemonTrainerRepository()
    {
        _connectionFactory = ConnectionFactory.GetInstance();
    }

    /// <summary>
    /// Returns all pokemon trainer records
    /// </summary>
    /// <returns>List of pokemon trainers</returns>
    public List<PokeTrainer> GetAllTrainers()
    {
        List<PokeTrainer> trainers = new List<PokeTrainer>();
        SqlConnection conn = _connectionFactory.GetConnection();

        conn.Open();

        SqlCommand cmd = new SqlCommand("Select * From PokeTrainer", conn);
        SqlDataReader reader = cmd.ExecuteReader();

        while(reader.Read())
        {
            trainers.Add(new PokeTrainer
            {
                Id = (int)reader["trainer_id"],
                Name = (string)reader["trainer_name"],
                Money = Convert.ToDecimal((double)reader["trainer_money"]),
                DoB = (DateTime)reader["date_of_birth"]
            });
        }
        reader.Close();
        conn.Close();

        foreach(PokeTrainer trainer in trainers)
        {
            Console.WriteLine($"{trainer.Id}: {trainer.Name}");
        }
        return trainers;
    }

    /// <summary>
    /// Get Pokemon Trainer by name
    /// </summary>
    /// <param name="name">exact name to search for</param>
    /// <returns>found Pokemon trainer object, if not found, returns null</returns>
    public PokeTrainer GetPokeTrainer(string name)
    {
        GetAllTrainers();
        return new PokeTrainer();
    }

    /// <summary>
    /// Gets pokemon trainer by its unique id
    /// </summary>
    /// <param name="id">integer id to search for</param>
    /// <returns>found poke trainer, if not null</returns>
    public PokeTrainer GetPokeTrainer(int id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Adds a new pokemon trainer record to db
    /// </summary>
    /// <param name="newTrainerToRegister">new PokeTrainer record to add</param>
    /// <returns>the same trainer, with the generated id</returns>
    public PokeTrainer AddPokeTrainer(PokeTrainer newTrainerToRegister)
    {
        throw new NotImplementedException();
    }
}