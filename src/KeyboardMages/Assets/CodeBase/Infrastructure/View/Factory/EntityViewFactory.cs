using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure.View.Factory
{
    public class EntityViewFactory : IEntityViewFactory
    {
        private readonly IInstantiator _instantiator;
        private readonly Vector3 _farAway = new(999f, 999f, 999f);
        
        public EntityBehaviour CreateView(EntityBehaviour prefab) =>
            _instantiator.InstantiatePrefabForComponent<EntityBehaviour>(
                prefab,
                position: _farAway,
                Quaternion.identity,
                parentTransform: null);
    }
}