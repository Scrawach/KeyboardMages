using CodeBase.Infrastructure.Systems;
using CodeBase.Infrastructure.View.Systems;

namespace CodeBase.Infrastructure.View
{
    public class ViewFeature : GenericFeature
    {
        public ViewFeature(ISystemFactory systems) : base(systems)
        {
            Add<BindEntityViewFromPrefabSystem>();
        }
    }
}