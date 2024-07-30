using CodeBase.Infrastructure.Common;
using CodeBase.Infrastructure.Common.AssetManagement;
using CodeBase.Infrastructure.Common.Identifiers;
using CodeBase.Infrastructure.Common.Scenes;
using CodeBase.Infrastructure.Systems;
using CodeBase.Infrastructure.View.Factory;
using Zenject;

namespace CodeBase.Infrastructure.Installers.Bootstrap.Bindings
{
    public static class InfrastructureExtensions
    {
        public static DiContainer BindInfrastructure(this DiContainer container) =>
            container
                .BindInfrastructureServices()
                .BindInfrastructureFactories();

        private static DiContainer BindInfrastructureServices(this DiContainer container)
        {
            container.Bind<ISystemFactory>().To<SystemFactory>().AsSingle();
            container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();
            container.Bind<IIdentifierService>().To<IdentifierService>().AsSingle();
            container.Bind<IAssets>().To<Assets>().AsSingle();
            
            container.BindInterfacesTo<CoroutineRunner>().FromNewComponentOnNewGameObject().AsSingle();

            return container;
        }

        private static DiContainer BindInfrastructureFactories(this DiContainer container)
        {
            container.Bind<IEntityViewFactory>().To<EntityViewFactory>().AsSingle();
            
            return container;
        }
    }
}