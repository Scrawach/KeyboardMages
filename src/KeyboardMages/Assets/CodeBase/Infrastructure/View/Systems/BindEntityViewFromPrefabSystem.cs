using System.Collections.Generic;
using CodeBase.Infrastructure.View.Factory;
using Entitas;

namespace CodeBase.Infrastructure.View.Systems
{
    public class BindEntityViewFromPrefabSystem : IExecuteSystem
    {
        private readonly IEntityViewFactory _factory;
        private readonly IGroup<GameEntity> _entities;

        private readonly List<GameEntity> _buffer = new(32);

        public BindEntityViewFromPrefabSystem(GameContext game, IEntityViewFactory factory)
        {
            _entities = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.ViewPrefab)
                .NoneOf(GameMatcher.View));
            
            _factory = factory;
        }

        public void Execute()
        {
            foreach (var entity in _entities.GetEntities(_buffer))
            {
                var behaviour = _factory.CreateView(entity.ViewPrefab);
                behaviour.SetupEntity(entity);
            }
        }
    }
}