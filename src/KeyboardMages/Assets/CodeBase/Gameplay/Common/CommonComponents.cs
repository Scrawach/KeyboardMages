using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace CodeBase.Gameplay.Common
{
    [Game] public class Id : IComponent { [PrimaryEntityIndex] public int Value; }
}