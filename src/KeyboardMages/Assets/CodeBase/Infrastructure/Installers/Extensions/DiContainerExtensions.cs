using Zenject;

namespace CodeBase.Infrastructure.Installers.Extensions
{
    public static class DiContainerExtensions
    {
        public static ConcreteIdBinderNonGeneric Bind<TContract1, TContract2>(this DiContainer container) => 
            container.Bind(typeof(TContract1), typeof(TContract2));
    }
}