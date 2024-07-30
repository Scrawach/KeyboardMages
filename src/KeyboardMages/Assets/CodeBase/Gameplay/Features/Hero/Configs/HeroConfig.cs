using UnityEngine;

namespace CodeBase.Gameplay.Features.Hero.Configs
{
    [CreateAssetMenu(fileName = "HeroConfig", menuName = "KeyboardMages/Configs/HeroConfig", order = 0)]
    public class HeroConfig : ScriptableObject
    {
        [field: SerializeField] public GameObject Prefab { get; private set; }
    }
}