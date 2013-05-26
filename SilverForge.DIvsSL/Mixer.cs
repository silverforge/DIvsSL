using SilverForge.DIvsSL.Fruits;

namespace SilverForge.DIvsSL
{
	/// <summary>
	/// Mixer class
	/// </summary>
	public class Mixer
	{
		/// <summary>
		/// private IApple member
		/// </summary>
		private readonly IApple _apple;
		/// <summary>
		/// Private IBanana member
		/// </summary>
		private readonly IBanana _banana;

		/// <summary>
		/// Constructor of <see cref="Mixer"/>
		/// </summary>
		/// <param name="apple">Implementation of IApple instance</param>
		/// <param name="banana">Implementation of IBanana instance</param>
		public Mixer(IApple apple, IBanana banana)
		{
			_apple = apple;
			_banana = banana;
		}

		/// <summary>
		/// Executes the mixing
		/// </summary>
		/// <returns>Taste of mixture</returns>
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