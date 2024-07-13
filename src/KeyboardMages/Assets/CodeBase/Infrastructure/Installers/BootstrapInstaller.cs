using CodeBase.Infrastructure.Installers.Extensions;
using Zenject;

namespace CodeBase.Infrastructure.Installers
{
    public class BootstrapInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInputs();
            Container.BindContexts();
            Container.BindInfrastructure();
        }
    }
}