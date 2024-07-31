using Entitas;
using UnityEngine;

namespace CodeBase.Inputs
{
    [Input] public class Input : IComponent { }
    [Input] public class AxisInput : IComponent { public Vector3 Value; }
}