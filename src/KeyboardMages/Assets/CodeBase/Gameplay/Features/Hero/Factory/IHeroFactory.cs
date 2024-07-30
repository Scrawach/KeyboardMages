using Entitas;
using UnityEngine;

namespace CodeBase.Gameplay.Features.Hero.Factory
{
    public interface IHeroFactory
    {
        GameEntity CreateHero(Vector3 position);
    }
}