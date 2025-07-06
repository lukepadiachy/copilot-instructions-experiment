using System.Collections.Generic;
using System.Threading.Tasks;
using PokeApiNet;
using CopilotWebApp.Interfaces;

namespace CopilotWebApp.Services
{
    public class PokemonService : IPokemonService
    {
        public async Task<List<Pokemon>> GetPokemonListAsync(int limit = 12, int offset = 0)
        {
            var client = new PokeApiClient();
            var page = await client.GetNamedResourcePageAsync<Pokemon>(limit: limit, offset: offset);
            var pokes = new List<Pokemon>();
            foreach (var entry in page.Results)
            {
                var poke = await client.GetResourceAsync<Pokemon>(entry.Name);
                pokes.Add(poke);
            }
            return pokes;
        }
    }
}
