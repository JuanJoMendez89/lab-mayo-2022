using Practica.EF.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Logic
{
    public abstract class BaseLogic
    {
        protected readonly NorthwindContext _context;

        public BaseLogic()
        {
            _context = new NorthwindContext();
        }
    }
}
