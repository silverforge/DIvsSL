using System;
using SilverForge.DIvsSL.Fruits;

namespace SilverForge.DIvsSL
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Constructor injection
			var mixer = new Mixer(new Apple(), new Banana());
			var doIt = mixer.DoIt();
			Console.WriteLine("DI Taste : {0}", doIt);

			// Service locator
			var fruitLocator = new FruitLocator();
			var mixer2 = new Mixer(fruitLocator.GetApple(), fruitLocator.GetBanana());
			var doIt2 = mixer2.DoIt();
			Console.WriteLine("SL Taste : {0}", doIt2);

			Console.ReadKey();
		}
	}
}
