namespace CodeBase.Infrastructure.View.Factory
{
    public interface IEntityViewFactory
    {
        EntityBehaviour CreateView(EntityBehaviour prefab);
    }
}