using FarmersCreed.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersCreed.Simulator
{
    public class AdvancedFarmSimulator : FarmSimulator
    {
        protected override void AddObjectToFarm(string[] inputCommands)
        {
            string type = inputCommands[1];
            string id = inputCommands[2];

            switch (type)
            {
                case "CherryTree":
                    {
                        var plant = new CherryTree(id);
                        this.farm.Plants.Add(plant);
                    }
                    break;
                default:
                    base.AddObjectToFarm(inputCommands);
                    break;
            }
        }
    }
}
