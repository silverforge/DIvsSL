using Microsoft.Practices.Unity;
using SilverForge.DIvsSL.Fruits;

namespace SilverForge.DIvsSL
{
	/// <summary>
	/// Sample implememtation of Service locator
	/// </summary>
	public class FruitLocator
	{
		/// <summary>
		/// The container
		/// </summary>
		private readonly IUnityContainer _container = new UnityContainer();

		/// <summary>
		/// Constructor of <see cref="FruitLocator"/>
		/// </summary>
		public FruitLocator()
		{
			_container.RegisterType<IApple, Apple>();
			_container.RegisterType<IBanana, Banana>();
		}

		/// <summary>
		/// Gets implementation of IApple
		/// </summary>
		/// <returns>Apple instance</returns>
		public IApple GetApple()
		{
			return _container.Resolve<IApple>();
		}

		/// <summary>
		/// Gets implementation of IBanana
		/// </summary>
		/// <returns>Banana instance</returns>
		public IBanana GetBanana()
		{
			return _container.Resolve<IBanana>();
		}

		/// <summary>
		/// Gets instance of T from container
		/// </summary>
		/// <typeparam name="T">The type of registered instance</typeparam>
		/// <returns>The instance</returns>
		public T Get<T>()
		{
			return _container.Resolve<T>();
		}
	}
}
