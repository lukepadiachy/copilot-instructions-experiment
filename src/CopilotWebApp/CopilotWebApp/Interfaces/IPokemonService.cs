using System.Collections.Generic;
using System.Threading.Tasks;
using PokeApiNet;

namespace CopilotWebApp.Interfaces
{
    public interface IPokemonService
    {
        Task<List<Pokemon>> GetPokemonListAsync(int limit = 12, int offset = 0);
    }
}
