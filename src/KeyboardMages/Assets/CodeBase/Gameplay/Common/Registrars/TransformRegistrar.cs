using CodeBase.Infrastructure.View.Registrars;

namespace CodeBase.Gameplay.Common.Registrars
{
    public class TransformRegistrar : MonoRegistrar
    {
        public override void Register(GameEntity entity) => 
            entity.AddTransform(transform);

        public override void Unregister(GameEntity entity)
        {
            if (entity.hasTransform)
                entity.RemoveTransform();
        }
    }
}