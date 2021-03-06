﻿using Microsoft.Practices.Unity;
using SilverForge.DIvsSL.Fruits;

namespace SilverForge.DIvsSL
{
	/// <summary>
	/// Sample implememtation of Service locator
	/// </summary>
	public sealed class FruitLocator
	{
		/// <summary>
		/// The container
		/// </summary>
		private readonly IUnityContainer _container = new UnityContainer();

		/// <summary>
		/// Private instance of <see cref="FruitLocator"/> 
		/// </summary>
		private readonly static FruitLocator instance = new FruitLocator();

		/// <summary>
		/// Constructor of <see cref="FruitLocator"/>
		/// </summary>
		private FruitLocator()
		{
			_container.RegisterType<IApple, Apple>();
			_container.RegisterType<IBanana, Banana>();
		}

		/// <summary>
		/// The sigleton instance of <see cref="FruitLocator"/>
		/// </summary>
		public static FruitLocator Instance
		{
			get { return instance; }
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
