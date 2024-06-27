using CodeBase.Infrastructure.Systems;
using Zenject;

namespace CodeBase.Infrastructure.Installers.Extensions
{
    public static class InfrastructureExtensions
    {
        public static DiContainer BindInfrastructure(this DiContainer container)
        {
            container.Bind<ISystemFactory>().To<SystemFactory>().AsSingle();
            
            return container;
        }
    }
}