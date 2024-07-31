using CodeBase.Common.Extensions;
using CodeBase.Gameplay.Features.Hero.Configs;
using CodeBase.Gameplay.Features.Hero.StaticData;
using CodeBase.Infrastructure.Common.Identifiers;
using UnityEngine;

namespace CodeBase.Gameplay.Features.Hero.Factory
{
    public class HeroFactory : IHeroFactory
    {
        private readonly GameContext _context;
        private readonly IIdentifierService _identifiers;
        private readonly IHeroStaticData _staticData;

        public HeroFactory(GameContext context, IIdentifierService identifiers, IHeroStaticData staticData)
        {
            _context = context;
            _identifiers = identifiers;
            _staticData = staticData;
        }

        public GameEntity CreateHero(Vector3 position) =>
            CreateHero(position, _staticData.GetHeroConfig());

        private GameEntity CreateHero(Vector3 position, HeroConfig config) =>
            _context
                .CreateEntity()
                .AddId(_identifiers.Next())
                .AddWorldPosition(position)
                .AddViewPrefab(config.Prefab)
                .AddSpeed(config.Speed)
                .With(entity => entity.isHero = true);
    }
}