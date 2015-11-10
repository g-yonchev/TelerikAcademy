namespace BiDictionary
{
	using System;
	using System.Collections.Generic;

	public class Startup
	{
		public static void Main()
		{
			var biDi = new BiDictionary<string, string, string>();
			
			biDi.Add("Pesho", "Peshov", "pehskata@abv.bg");
			biDi.Add("Gosho", "Goshov", "gogata@abv.bg");
			biDi.Add("Tosho", "Toshov", "tosheto@abv.bg");

			var pesho = biDi.FindByKey1("Pesho");
			Console.WriteLine(pesho);

			var gosho = biDi.FindByKey2("Goshov");
			Console.WriteLine(gosho);

			var tosho = biDi.FindByTwoKeys("Tosho", "Toshov");
			Console.WriteLine(tosho);
		}
	}
}
