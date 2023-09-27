using Microsoft.EntityFrameworkCore;
using Pokedex_API.Models;

namespace Pokedex_API.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly PokemonContext _context;
        public PokemonRepository(PokemonContext context)
        {
            _context = context;
        }

        public async Task<Pokemon> Create(Pokemon pokemon)
        {
            _context.Pokemons.Add(pokemon);
            await _context.SaveChangesAsync();
            
            return pokemon;
        }

        public async Task Delete(int id)
        {
            var pokemon = await _context.Pokemons.FindAsync(id);
            _context.Pokemons.Remove(pokemon);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Pokemon>> Get()
        {
            var pokemons = await _context.Pokemons.ToListAsync();
            return pokemons;
        }

        public async Task<Pokemon> Get(int id)
        {
            var pokemon = await _context.Pokemons.FindAsync(id);
            return pokemon;
        }

        public async Task Update(Pokemon pokemon)
        {
            _context.Update(pokemon);
            await _context.SaveChangesAsync();

        }
    }
}
