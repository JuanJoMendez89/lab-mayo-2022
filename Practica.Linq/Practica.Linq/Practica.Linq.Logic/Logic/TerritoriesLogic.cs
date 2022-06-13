using Practica.Linq.Data.Data;
using Practica.Linq.Entities.Entities;
using Practica.Linq.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Logic.Logic
{
    public class TerritoriesLogic : BaseLogic<Territories, string>
    {
        private readonly TerritoriesData _territoriesData;

        public TerritoriesLogic()
        {
            _territoriesData = new TerritoriesData();
        }

        public override void Add(Territories entity)
        {
            _territoriesData.Add(entity);
        }

        public override void Delete(string id)
        {
            _territoriesData.Delete(id);
        }

        public override DataTable GetAll()
        {
            return ConvertirListaATabla(_territoriesData.GetAll());
        }

        public override DataTable GetByID(string id)
        {
            return ConvertirEntidadATabla(_territoriesData.GetByID(id));
        }

        public override void Update(Territories entity)
        {
            _territoriesData.Update(entity);
        }
    }
}
