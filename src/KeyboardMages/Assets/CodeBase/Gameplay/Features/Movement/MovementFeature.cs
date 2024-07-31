using CodeBase.Gameplay.Features.Movement.Systems;
using CodeBase.Infrastructure.Systems;

namespace CodeBase.Gameplay.Features.Movement
{
    public class MovementFeature : GenericFeature
    {
        public MovementFeature(ISystemFactory systems) : base(systems)
        {
            Add<UpdateTransformPositionSystem>();
        }
    }
}