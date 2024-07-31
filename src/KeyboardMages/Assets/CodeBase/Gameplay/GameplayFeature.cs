using CodeBase.Gameplay.Features.Hero;
using CodeBase.Gameplay.Features.Input;
using CodeBase.Gameplay.Features.Movement;
using CodeBase.Infrastructure.Systems;
using CodeBase.Infrastructure.View;

namespace CodeBase.Gameplay
{
    public class GameplayFeature : GenericFeature
    {
        public GameplayFeature(ISystemFactory systems) : base(systems)
        {
            Add<InputFeature>();
            Add<ViewFeature>();
            Add<HeroFeature>();
            Add<MovementFeature>();
        }
    }
}