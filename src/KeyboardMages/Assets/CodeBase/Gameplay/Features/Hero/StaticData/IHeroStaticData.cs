using CodeBase.Gameplay.Features.Hero.Configs;
using CodeBase.Infrastructure.Common.StaticData;

namespace CodeBase.Gameplay.Features.Hero.StaticData
{
    public interface IHeroStaticData : IStaticDataLoader
    {
        HeroConfig GetHeroConfig();
    }
}