using Practica.EF.Data.Data;
using Practica.EF.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Logic
{
    public class PokemonLogic
    {
        private readonly PokemonData _pokemonData;

        public PokemonLogic()
        {
            _pokemonData = new PokemonData();
        }
        public async Task<Pokemon> GetPokemon(string name)
        {
            return await _pokemonData.GetPokemon(name);
        }
    }
}
