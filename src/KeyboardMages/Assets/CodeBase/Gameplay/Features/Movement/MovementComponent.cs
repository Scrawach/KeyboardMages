using Entitas;
using UnityEngine;

namespace CodeBase.Gameplay.Features.Movement
{
    [Game] public class Speed : IComponent { public float Value; }
    [Game] public class Direction : IComponent { public Vector3 Value; }
}