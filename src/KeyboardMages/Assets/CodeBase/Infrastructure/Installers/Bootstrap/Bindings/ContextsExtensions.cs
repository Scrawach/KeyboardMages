using Zenject;

namespace CodeBase.Infrastructure.Installers.Bootstrap.Bindings
{
    public static class ContextsExtensions
    {
        public static DiContainer BindEntitasContexts(this DiContainer container)
        {
            container.Bind<Contexts>().FromInstance(Contexts.sharedInstance).AsSingle();
            
            container.Bind<GameContext>().FromInstance(Contexts.sharedInstance.game).AsSingle();
            container.Bind<InputContext>().FromInstance(Contexts.sharedInstance.input).AsSingle();
            
            return container;
        }
    }
}