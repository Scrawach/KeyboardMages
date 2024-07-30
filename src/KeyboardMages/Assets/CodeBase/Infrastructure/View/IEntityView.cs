using UnityEngine;

namespace CodeBase.Infrastructure.View
{
    public interface IEntityView
    {
        GameEntity Entity { get; }
        GameObject GameObject { get; }
        void SetupEntity(GameEntity entity);
        void ReleaseEntity();
    }
}