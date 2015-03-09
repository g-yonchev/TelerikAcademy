namespace MobilePhone
{
    using System;

    public class GSMTest
    {
        GSM[] arrayOfGSMs = new GSM[10];

        public GSM[] CreateGSMs()
        {
            for (int i = 0; i < 10; i++)
            {
                arrayOfGSMs[i] = new GSM("Nokia", "3310", 100 + i, "Joro");
            }
            return arrayOfGSMs;
        }
    }
}
