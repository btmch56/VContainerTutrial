using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace VContainerTutrial
{
    public class GameLifetimeScope : LifetimeScope
    {
        [SerializeField]
        HelloWorldScreen _helloWorldScreen;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<GamePresenter>();
            builder.Register<HelloWorldService>(Lifetime.Singleton);
            builder.RegisterComponent(_helloWorldScreen);
        }
    }
}




