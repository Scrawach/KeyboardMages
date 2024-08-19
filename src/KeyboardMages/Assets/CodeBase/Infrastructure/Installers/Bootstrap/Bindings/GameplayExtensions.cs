using CodeBase.Gameplay.Common.Time;
using CodeBase.Gameplay.Features.Cameras.Services;
using CodeBase.Gameplay.Features.Hero.Factory;
using CodeBase.Gameplay.Features.Hero.StaticData;
using CodeBase.Gameplay.Levels;
using CodeBase.Infrastructure.Common.StaticData;
using CodeBase.Infrastructure.Installers.Extensions;
using Zenject;

namespace CodeBase.Infrastructure.Installers.Bootstrap.Bindings
{
    public static class GameplayExtensions
    {
        public static DiContainer BindGameplay(this DiContainer container) =>
            container
                .BindStaticData()
                .BindServices()
                .BindFactories();

        private static DiContainer BindServices(this DiContainer container)
        {
            container.Bind<ICameraProvider>().To<CameraProvider>().AsSingle();
            container.Bind<ILevelDataProvider>().To<LevelDataProvider>().AsSingle();
            container.Bind<ITimeService>().To<UnityTimeService>().AsSingle();

            return container;
        }

        private static DiContainer BindFactories(this DiContainer container)
        {
            container.Bind<IHeroFactory>().To<HeroFactory>().AsSingle();

            return container;
        }

        private static DiContainer BindStaticData(this DiContainer container)
        {
            container.Bind<IHeroStaticData, IStaticDataLoader>().To<HeroStaticData>().AsSingle();
            
            return container;
        }
    }
}