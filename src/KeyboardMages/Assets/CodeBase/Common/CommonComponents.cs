using CodeBase.Infrastructure.View;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace CodeBase.Common
{
    [Game] public class Id : IComponent { [PrimaryEntityIndex] public int Value; }
    
    [Game] public class View : IComponent { public IEntityView Value; }
    [Game] public class ViewPrefab : IComponent { public EntityBehaviour Value; }
}