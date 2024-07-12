using Zenject;

namespace CodeBase.Infrastructure.Installers.Extensions
{
    public static class ContextsExtensions
    {
        public static DiContainer BindContexts(this DiContainer container)
        {
            container.Bind<Contexts>().FromInstance(Contexts.sharedInstance).AsSingle();
            
            container.Bind<GameContext>().FromInstance(Contexts.sharedInstance.game).AsSingle();
            container.Bind<InputContext>().FromInstance(Contexts.sharedInstance.input).AsSingle();
            
            return container;
        }
    }
}