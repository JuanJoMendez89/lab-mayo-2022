using Practica.Linq.Data.Data;
using Practica.Linq.Entities.Entities;
using Practica.Linq.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Logic.Logic
{
    public class RegionLogic : IABMLogic<Region, int>
    {
        private readonly RegionData _regionData;

        public RegionLogic()
        {
            _regionData = new RegionData();
        }

        public void Add(Region entity)
        {
            _regionData.Add(entity);
        }

        public void Delete(int id)
        {
            _regionData.Delete(id);
        }

        public List<Region> GetAll()
        {
            return _regionData.GetAll();
        }

        public Region GetByID(int id)
        {
            return _regionData.GetByID(id);
        }

        public void Update(Region entity)
        {
            _regionData.Update(entity);
        }
    }
}
