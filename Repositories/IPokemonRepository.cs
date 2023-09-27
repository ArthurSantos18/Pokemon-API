using Pokedex_API.Models;

namespace Pokedex_API.Repositories
{
    public interface IPokemonRepository
    {
        Task<IEnumerable<Pokemon>> Get();
        Task<Pokemon> Get(int id);
        Task<Pokemon> Create(Pokemon pokemon);
        Task Update(Pokemon pokemon);
        Task Delete(int id);
    }
}
