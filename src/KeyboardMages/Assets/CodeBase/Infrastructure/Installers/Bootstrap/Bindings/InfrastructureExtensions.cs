using CodeBase.Infrastructure.Common;
using CodeBase.Infrastructure.Common.Identifiers;
using CodeBase.Infrastructure.Common.Scenes;
using CodeBase.Infrastructure.Systems;
using Zenject;

namespace CodeBase.Infrastructure.Installers.Bootstrap.Bindings
{
    public static class InfrastructureExtensions
    {
        public static DiContainer BindInfrastructure(this DiContainer container)
        {
            container.Bind<ISystemFactory>().To<SystemFactory>().AsSingle();
            container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();
            container.Bind<IIdentifierService>().To<IdentifierService>().AsSingle();
            
            container.BindInterfacesTo<CoroutineRunner>().FromNewComponentOnNewGameObject().AsSingle();

            return container;
        }
    }
}