using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace CodeBase.Gameplay.Common
{
    [Game] public class Id : IComponent { [PrimaryEntityIndex] public int Value; }
    
    [Game] public class WorldPosition : IComponent { public Vector3 Value; }
}