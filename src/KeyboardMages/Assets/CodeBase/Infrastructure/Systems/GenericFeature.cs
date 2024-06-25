using Entitas;

namespace CodeBase.Infrastructure.Systems
{
    public class GenericFeature : Feature
    {
        private readonly ISystemFactory _systems;

        public GenericFeature(ISystemFactory systems) => 
            _systems = systems;

        public Entitas.Systems Add<TSystem>() where TSystem : ISystem => 
            Add(_systems.Create<TSystem>());

        public Entitas.Systems Add<TSystem>(params object[] args) where TSystem : ISystem => 
            Add(_systems.Create<TSystem>());
    }
}