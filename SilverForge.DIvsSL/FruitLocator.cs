using Microsoft.Practices.Unity;
using SilverForge.DIvsSL.Fruits;

namespace SilverForge.DIvsSL
{
	public class FruitLocator
	{
		private readonly IUnityContainer _container = new UnityContainer();

		public FruitLocator()
		{
			_container.RegisterType<IApple, Apple>();
			_container.RegisterType<IBanana, Banana>();
		}

		public IApple GetApple()
		{
			return _container.Resolve<IApple>();
		}

		public IBanana GetBanana()
		{
			return _container.Resolve<IBanana>();
		}
	}
}