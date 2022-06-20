using Newtonsoft.Json;
using Practica.EF.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Data.Data
{
    public class PokemonData
    {
        public async Task<Pokemon> GetPokemon(string name) {
            try
            {
                HttpClient client = new HttpClient();
                var json = await client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/" + name);
                var pokemon = JsonConvert.DeserializeObject<Pokemon>(json);

                return pokemon;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
