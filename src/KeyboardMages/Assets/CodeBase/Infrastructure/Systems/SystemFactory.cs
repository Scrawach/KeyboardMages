using Entitas;
using Zenject;

namespace CodeBase.Infrastructure.Systems
{
    public class SystemFactory : ISystemFactory
    {
        private readonly IInstantiator _instantiator;

        public SystemFactory(IInstantiator instantiator) => 
            _instantiator = instantiator;

        public TSystem Create<TSystem>() where TSystem : ISystem => 
            _instantiator.Instantiate<TSystem>();

        public TSystem Create<TSystem>(params object[] args) where TSystem : ISystem => 
            _instantiator.Instantiate<TSystem>(args);
    }
}