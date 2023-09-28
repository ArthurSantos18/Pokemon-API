using Microsoft.AspNetCore.Mvc;
using Pokedex_API.Models;
using Pokedex_API.Repositories;

namespace Pokedex_API.Controllers
{
    [Route("api/Controller")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonRepository _pokemonRepository;
        public PokemonController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Pokemon>> GetAllAsync()
        {
            return await _pokemonRepository.GetAllAsync();
        }

        [HttpGet("(id)")]
        public async Task<ActionResult<Pokemon>> GetAsync(int id)
        {
            return await _pokemonRepository.GetAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<Pokemon>> CreateAsync([FromBody] Pokemon pokemon)
        {
            var newPokemon = await _pokemonRepository.CreateAsync(pokemon);
            return pokemon;
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync(int id, [FromBody] Pokemon pokemon)
        {
            if (id != pokemon.Id)
            {
                return BadRequest();
            }
            await _pokemonRepository.UpdateAsync(pokemon); ;
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var pokemonDelete = await _pokemonRepository.GetAsync(id);
            if (pokemonDelete == null)
            {
                return NotFound();
            }
            await _pokemonRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
