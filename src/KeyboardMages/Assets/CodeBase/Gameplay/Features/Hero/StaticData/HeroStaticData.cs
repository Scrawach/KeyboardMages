using CodeBase.Gameplay.Features.Hero.Configs;
using CodeBase.Infrastructure.Common.AssetManagement;

namespace CodeBase.Gameplay.Features.Hero.StaticData
{
    public class HeroStaticData : IHeroStaticData
    {
        private const string HeroConfigPath = "Configs/Gameplay/HeroConfig";
        
        private readonly IAssets _assets;

        private HeroConfig _heroConfig;

        public HeroStaticData(IAssets assets) => 
            _assets = assets;

        public void Load() => 
            _heroConfig = _assets.Load<HeroConfig>(HeroConfigPath);

        public HeroConfig GetHeroConfig() => 
            _heroConfig;
    }
}