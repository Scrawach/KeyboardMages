using CodeBase.Infrastructure.View;
using Entitas;

namespace CodeBase.Common
{
    [Game] public class View : IComponent { public IEntityView Value; }
    [Game] public class ViewPrefab : IComponent { public EntityBehaviour Value; }
}