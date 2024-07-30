namespace CodeBase.Infrastructure.View.Registrars
{
    public interface IEntityComponentsRegistrar
    {
        void Register(GameEntity entity);
        void Unregister(GameEntity entity);
    }
}