using CodeBase.Infrastructure.View;
using UnityEngine;

namespace CodeBase.Gameplay.Features.Hero.Configs
{
    [CreateAssetMenu(fileName = "HeroConfig", menuName = "KeyboardMages/Configs/HeroConfig", order = 0)]
    public class HeroConfig : ScriptableObject
    {
        [field: SerializeField] public EntityBehaviour Prefab { get; private set; }
        [field: SerializeField] public float Speed { get; private set; }
    }
}