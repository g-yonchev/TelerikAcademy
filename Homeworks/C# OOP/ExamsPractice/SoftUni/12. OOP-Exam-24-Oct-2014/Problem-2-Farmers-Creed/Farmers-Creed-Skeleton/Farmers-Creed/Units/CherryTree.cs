using FarmersCreed.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersCreed.Units
{
    class CherryTree : FoodPlant, IProductProduceable
    {
        public CherryTree(string id)
            : base(id, 14, 4, 3)
        {

        }
    }
}
