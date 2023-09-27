using Microsoft.EntityFrameworkCore;

namespace Pokedex_API.Models
{
    public class PokemonContext : DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }

        public PokemonContext(DbContextOptions<PokemonContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
