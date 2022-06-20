using Practica.EF.Entities.Models;
using Practica.EF.Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Practica.EF.Web.MVC.PokeApi.Controllers
{
    public class PokemonController : Controller
    {
        PokemonLogic pokemonLogic = new PokemonLogic();
        // GET: Pokemon
        public async Task<ActionResult> Index(string name) {
            try
            {
                Pokemon pokemon = await pokemonLogic.GetPokemon(name);
                return View(pokemon);
            }
            catch (Exception)
            {
                return View("NotFound");
            }

        }

    }
}
