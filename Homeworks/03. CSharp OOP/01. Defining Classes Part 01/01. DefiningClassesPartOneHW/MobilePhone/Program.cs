namespace MobilePhone
{
    using System;

    class Program
    {
        static void Main()
        {
            Battery currentBattery = new Battery("H-98",20,20,BatteryType.NiCd);
            Display currentDisplay = new Display(20, 30);
            GSM myGSM = new GSM("Nokia", "3310", 100, "Joro", currentBattery, currentDisplay);
            // Console.WriteLine(myGSM);
            // Console.WriteLine(GSM.iPhone4S);
        }
    }
}
