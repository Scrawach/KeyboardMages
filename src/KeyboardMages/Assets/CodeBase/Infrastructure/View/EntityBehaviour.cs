using CodeBase.Infrastructure.View.Registrars;
using UnityEngine;

namespace CodeBase.Infrastructure.View
{
    public class EntityBehaviour : MonoBehaviour, IEntityView
    {
        public GameEntity Entity { get; private set; }
        
        public GameObject GameObject => gameObject;
        
        public void SetupEntity(GameEntity entity)
        {
            Entity = entity;
            Entity.AddView(this);
            Entity.Retain(this);

            foreach (var registrar in GetComponentsInChildren<IEntityComponentsRegistrar>()) 
                registrar.Register(Entity);
        }

        public void ReleaseEntity()
        {
            foreach (var registrar in GetComponentsInChildren<IEntityComponentsRegistrar>()) 
                registrar.Unregister(Entity);
            
            Entity.Release(this);
            Entity = default;
        }
    }
}