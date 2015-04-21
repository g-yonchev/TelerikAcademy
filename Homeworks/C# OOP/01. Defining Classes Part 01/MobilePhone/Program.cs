namespace MobilePhone
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            // Test here

            //GSMTest gsmTest = new GSMTest();
            //Console.WriteLine(gsmTest.TestMobilePhoneCreation());
            GSMCallHistoryTest callTest = new GSMCallHistoryTest();
            Console.WriteLine(callTest.TestCallsAdding());
            GSMCallFixedPrice callPrice = new GSMCallFixedPrice();
            Console.WriteLine(callPrice.CalculatePrice());
        }
    }

    public class GSMTest
    {
        public string TestMobilePhoneCreation()
        {
            Battery myBattery = new Battery("Some Battery");
            myBattery.HoursIdle = 100;
            myBattery.HoursTalk = 200;
            myBattery.Type = BatteryType.LiPoly;

            Display myDisplay = new Display();
            myDisplay.Colors = 2000;
            myDisplay.Size = 5.0;

            GSM myGSM = new GSM(Manufacturer.SAMSUNG, "Note 3", myBattery, myDisplay);
            myGSM.Owner = "Pesho";
            myGSM.Price = 400.0M;

            return myGSM.ToString();
        }
    }

    public class GSMCallHistoryTest
    {
        public string TestCallsAdding()
        {
            GSM myGSM = new GSM(Manufacturer.NOKIA, "3310");

            myGSM.AddCall(new Call(DateTime.Now, "0889", 200));
            myGSM.AddCall(new Call(DateTime.Now, "0886", 300));

            StringBuilder result = new StringBuilder();

            foreach (var call in myGSM.Calls)
            {
                result.AppendLine(call.ToString());
            }
            return result.ToString();

        }
    }

    public class GSMCallFixedPrice
    {
        public string CalculatePrice()
        {
            GSM someGSM = new GSM(Manufacturer.APPLE, "Iphone4S");

            someGSM.AddCall(new Call(DateTime.Now, "0889", 200));
            someGSM.AddCall(new Call(DateTime.Now, "0886", 400));
            someGSM.AddCall(new Call(DateTime.Now, "0887", 430));

            decimal totalPrice = someGSM.TotalCallPrice(0.37M);
            return string.Format("{0:C}", totalPrice);
        }
    }


}
