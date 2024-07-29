using CodeBase.Infrastructure.Installers.Bootstrap.Bindings;
using Zenject;

namespace CodeBase.Infrastructure.Installers.Bootstrap
{
    public class BootstrapInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInputs();
            Container.BindEntitasContexts();
            Container.BindInfrastructure();
        }
    }
}