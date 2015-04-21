using FarmersCreed.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersCreed.Units
{
    class Cow : Animal, IProductProduceable
    {
        public Cow(string id)
            : base(id, 15, 6)
        {

        }
    }
}
