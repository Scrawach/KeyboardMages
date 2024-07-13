using CodeBase.Gameplay.Features.Input.Service;
using Zenject;

namespace CodeBase.Infrastructure.Installers.Extensions
{
    public static class InputExtensions
    {
        public static DiContainer BindInputs(this DiContainer container)
        {
            container.Bind<IInput>().To<StandaloneInput>().AsSingle();

            return container;
        }
    }
}