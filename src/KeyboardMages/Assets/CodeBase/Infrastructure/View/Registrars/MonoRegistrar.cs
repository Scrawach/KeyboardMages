using UnityEngine;

namespace CodeBase.Infrastructure.View.Registrars
{
    public abstract class MonoRegistrar : MonoBehaviour, IEntityComponentsRegistrar
    {
        public abstract void Register(GameEntity entity);
        public abstract void Unregister(GameEntity entity);
    }
}