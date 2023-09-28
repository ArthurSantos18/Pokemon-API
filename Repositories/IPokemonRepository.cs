using Pokedex_API.Models;

namespace Pokedex_API.Repositories
{
    public interface IPokemonRepository
    {
        Task<IEnumerable<Pokemon>> GetAllAsync();
        Task<Pokemon> GetAsync(int id);
        Task<Pokemon> CreateAsync(Pokemon pokemon);
        Task UpdateAsync(Pokemon pokemon);
        Task DeleteAsync(int id);
    }
}
