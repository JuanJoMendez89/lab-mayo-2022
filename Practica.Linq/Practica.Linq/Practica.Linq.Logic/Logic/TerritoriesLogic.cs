﻿using Practica.Linq.Data.Data;
using Practica.Linq.Entities.Entities;
using Practica.Linq.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Logic.Logic
{
    public class TerritoriesLogic : IABMLogic<Territories, string>
    {
        private readonly TerritoriesData _territoriesData;

        public TerritoriesLogic()
        {
            _territoriesData = new TerritoriesData();
        }

        public void Add(Territories entity)
        {
            _territoriesData.Add(entity);
        }

        public void Delete(string id)
        {
            _territoriesData.Delete(id);
        }

        public List<Territories> GetAll()
        {
            return _territoriesData.GetAll();
        }

        public Territories GetByID(string id)
        {
            return _territoriesData.GetByID(id);
        }

        public void Update(Territories entity)
        {
            _territoriesData.Update(entity);
        }
    }
}
