using FarmersCreed.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersCreed.Units
{
    class Swine : Animal, IProductProduceable
    {
        public Swine(string id)
            : base(id, 20, 1)
        {

        }
    }
}
