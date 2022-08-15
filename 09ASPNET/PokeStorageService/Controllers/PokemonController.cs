using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PokeStorageService.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PokemonController : ControllerBase
{
    private readonly PokemonService _service;

    public PokemonController(PokemonService service)
    {
        _service = service;
    }
    // GET: api/<PokemonController>?value=""
    [HttpGet]
    public ActionResult<Pokemon> Get(int? trainerId)
    {
        List<Pokemon> pokes = new(); 
        if(trainerId == null) {
            pokes = _service.GetAllPokemons();
        
        } else {
            pokes = _service.GetPokemonsByTrainerId((int)trainerId);

        }
        return pokes.Count > 0 ? Ok(pokes) : NoContent();
    }

    // GET api/<PokemonController>/5
    //Get Request handler with Route parameter
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<PokemonController>
    [HttpPost]
    public ActionResult<Pokemon> Post([FromBody] Pokemon pokeToCreate)
    {
        Pokemon createdPoke = _service.DepositPokemon(pokeToCreate);
        return Created($"pokemon/{createdPoke.Id}", createdPoke);
    }

    // PUT api/<PokemonController>/update/5
    [HttpPut("update/{id}")]
    public void Put([FromRoute] int id, [FromBody] string value)
    {
    }

    [HttpPut("{id}")]
    public void PutWithoutUpdate([FromRoute] int id, [FromBody] string value)
    {
    }

    // DELETE api/<PokemonController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
