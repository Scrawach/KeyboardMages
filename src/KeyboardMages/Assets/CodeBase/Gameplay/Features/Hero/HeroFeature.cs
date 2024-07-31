using CodeBase.Gameplay.Features.Hero.Systems;
using CodeBase.Infrastructure.Systems;

namespace CodeBase.Gameplay.Features.Hero
{
    public class HeroFeature : GenericFeature
    {
        public HeroFeature(ISystemFactory systems) : base(systems)
        {
            Add<InitializeHeroSystem>();

            Add<SetMovingByAxisInput>();
            Add<SetHeroDirectionByInputSystem>();
        }
    }
}