using CodeBase.Inputs.Service;
using Zenject;

namespace CodeBase.Infrastructure.Installers.Bootstrap.Bindings
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