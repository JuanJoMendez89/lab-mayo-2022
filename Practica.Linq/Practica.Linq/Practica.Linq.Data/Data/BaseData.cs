using Practica.Linq.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Data.Data
{
    public abstract class BaseData
    {
        protected readonly NorthwindContext _context;
        public BaseData()
        {
            _context = new NorthwindContext();
        }
    }
}
