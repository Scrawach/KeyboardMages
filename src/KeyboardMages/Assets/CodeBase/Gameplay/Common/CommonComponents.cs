using Entitas;
using UnityEngine;

namespace CodeBase.Gameplay.Common
{
    [Game] public class WorldPosition : IComponent { public Vector3 Value; }

    [Game] public class TransformComponent : IComponent { public Transform Value; }
}