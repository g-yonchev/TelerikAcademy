using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class HoldingPenAdvanced : HoldingPen
    {
        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Tank":
                    var tank = new Tank(commandWords[2]);
                    base.InsertUnit(tank);
                    break;
                case "Marine":
                    var marine = new Marine(commandWords[2]);
                    base.InsertUnit(marine);
                    break;
                default:
                    base.ExecuteInsertUnitCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Weapon":
                    break;
                default:
                    base.ExecuteAddSupplementCommand(commandWords);
                    break;
            }
        }
    }
}
