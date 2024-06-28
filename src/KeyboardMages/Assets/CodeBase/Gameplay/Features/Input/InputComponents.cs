using Entitas;
using UnityEngine;

namespace CodeBase.Gameplay.Features.Input
{
    [Input] public class Input : IComponent { }
    [Input] public class AxisInput : IComponent { public Vector2 Value; }
}