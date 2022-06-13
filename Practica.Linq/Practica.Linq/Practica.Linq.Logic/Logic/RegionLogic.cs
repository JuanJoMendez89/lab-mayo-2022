﻿using Practica.Linq.Data.Data;
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
    public class RegionLogic : BaseLogic<Region, int>
    {
        private readonly RegionData _regionData;

        public RegionLogic()
        {
            _regionData = new RegionData();
        }

        public override void Add(Region entity)
        {
            _regionData.Add(entity);
        }

        public override void Delete(int id)
        {
            _regionData.Delete(id);
        }

        public override DataTable GetAll()
        {
            return ConvertirListaATabla(_regionData.GetAll());
        }

        public override DataTable GetByID(int id)
        {
            return ConvertirEntidadATabla(_regionData.GetByID(id));
        }

        public override void Update(Region entity)
        {
            _regionData.Update(entity);
        }
    }
}
