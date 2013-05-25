using SilverForge.DIvsSL.Fruits;

namespace SilverForge.DIvsSL
{
	public class Mixer
	{
		private readonly IApple _apple;
		private readonly IBanana _banana;

		public Mixer(IApple apple, IBanana banana)
		{
			_apple = apple;
			_banana = banana;
		}

		public Tastes DoIt()
		{
			if (_apple == null)
				return Tastes.Neutral;

			if (_banana == null)
				return Tastes.Neutral;

			return Tastes.Bitter;
		}
	}
}