using Models;
using Microsoft.Data.SqlClient;
using CustomExceptions;

namespace DataAccess;

public class PokemonRepository : IPokemonRepository
{
    private readonly ConnectionFactory _connectionFactory;

    public PokemonRepository(ConnectionFactory factory)
    {
        _connectionFactory = factory;
    }
    public List<Pokemon> GetAllPokemons()
    {
        List<Pokemon> pokes = new();
        using SqlCommand command = new SqlCommand("Select * From Pokemons", _connectionFactory.GetConnection());

        using SqlDataReader reader = command.ExecuteReader();

        if(reader.Read())
        {
            pokes.Add(new Pokemon{
                Id = (int) reader["pokemon_id"],
                Name = (string) reader["pokemon_name"],
                Level = (int) reader["level"],
                Type = (string) reader["type"],
                TrainerId = (int) reader["trainer_id"]
            });
        }

        return pokes;
    }

    public Pokemon GetPokemonByPokemonId(int pokemonId)
    {
        using SqlCommand command = new SqlCommand("Select * From Pokemons", _connectionFactory.GetConnection());
        using SqlDataReader reader = command.ExecuteReader();

        if(reader.Read())
        {
            return new Pokemon{
                Id = (int) reader["pokemon_id"],
                Name = (string) reader["pokemon_name"],
                Level = (int) reader["level"],
                Type = (string) reader["type"],
                TrainerId = (int) reader["trainer_id"]
            };
        }

        throw new RecordNotFoundException($"Pokemon with the id {pokemonId} has not been found");
    }

    /// <summary>
    /// Gets all pokemon by Trainer Id
    /// </summary>
    /// <param name="trainerId">int representation of trainer id</param>
    /// <returns>List of pokemons belonging to a particular pokemon traienr</returns>
    public List<Pokemon> GetPokemonsByTrainerId(int trainerId)
    {
        List<Pokemon> pokes = new();
        using SqlCommand command = new SqlCommand("Select * From Pokemons Where trainer_id = @id", _connectionFactory.GetConnection());
        command.Parameters.AddWithValue("@id", trainerId);

        using SqlDataReader reader = command.ExecuteReader();

        if(reader.Read())
        {
            pokes.Add(new Pokemon{
                Id = (int) reader["pokemon_id"],
                Name = (string) reader["pokemon_name"],
                Level = (int) reader["level"],
                Type = (string) reader["type"],
                TrainerId = (int) reader["trainer_id"]
            });
        }

        return pokes;
    }

    public Pokemon AddPokemon(Pokemon poke)
    {
        using SqlCommand cmd = new SqlCommand("insert into Pokemons (pokemon_name, level, type, trainer_id) output INSERTED.pokemon_id Values (@name, @lvl, @type, @tId)", _connectionFactory.GetConnection());

        cmd.Parameters.AddWithValue("@name", poke.Name);
        cmd.Parameters.AddWithValue("@lvl", poke.Level);
        cmd.Parameters.AddWithValue("@type", poke.Type);
        cmd.Parameters.AddWithValue("@tId", poke.TrainerId);

        int insertedId = (int) cmd.ExecuteScalar();

        poke.Id = insertedId;

        return poke;
    }

    public bool DeletePokemon(int pokeId)
    {
        using SqlCommand cmd = new SqlCommand("Delete From Pokemons Where pokemon_id = @pokeId", _connectionFactory.GetConnection());

        cmd.Parameters.AddWithValue("@pokeId", pokeId);

        int rowsAffected = (int) cmd.ExecuteNonQuery();

        return rowsAffected > 0;
    }
}