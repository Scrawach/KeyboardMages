using CodeBase.Gameplay.Features.Hero;
using CodeBase.Gameplay.Features.Input;
using CodeBase.Infrastructure.Systems;

namespace CodeBase.Gameplay
{
    public class GameplayFeature : GenericFeature
    {
        public GameplayFeature(ISystemFactory systems) : base(systems)
        {
            Add<InputFeature>();
            Add<HeroFeature>();
        }
    }
}