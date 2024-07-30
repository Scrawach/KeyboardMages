using CodeBase.Infrastructure.Common.Identifiers;
using UnityEngine;

namespace CodeBase.Gameplay.Features.Hero.Factory
{
    public class HeroFactory : IHeroFactory
    {
        private readonly GameContext _context;
        private readonly IIdentifierService _identifiers;

        public HeroFactory(GameContext context, IIdentifierService identifiers)
        {
            _context = context;
            _identifiers = identifiers;
        }

        public GameEntity CreateHero(Vector3 position) =>
            _context
                .CreateEntity()
                .AddId(_identifiers.Next());
    }
}