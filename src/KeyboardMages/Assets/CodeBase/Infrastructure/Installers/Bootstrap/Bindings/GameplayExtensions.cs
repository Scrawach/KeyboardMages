using CodeBase.Gameplay.Features.Cameras.Services;
using Zenject;

namespace CodeBase.Infrastructure.Installers.Bootstrap.Bindings
{
    public static class GameplayExtensions
    {
        public static DiContainer BindGameplayServices(this DiContainer container)
        {
            container.Bind<ICameraProvider>().To<CameraProvider>().AsSingle();

            return container;
        }
    }
}