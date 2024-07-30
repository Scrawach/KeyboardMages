using CodeBase.Gameplay.Features.Cameras.Services;
using CodeBase.Gameplay.Features.Hero.Factory;
using CodeBase.Gameplay.Levels;
using Zenject;

namespace CodeBase.Infrastructure.Installers.Bootstrap.Bindings
{
    public static class GameplayExtensions
    {
        public static DiContainer BindGameplayServices(this DiContainer container)
        {
            container.Bind<ICameraProvider>().To<CameraProvider>().AsSingle();
            container.Bind<ILevelDataProvider>().To<LevelDataProvider>().AsSingle();

            return container;
        }

        public static DiContainer BindGameplayFactories(this DiContainer container)
        {
            container.Bind<IHeroFactory>().To<HeroFactory>().AsSingle();

            return container;
        }
    }
}