using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure.Installers.Common
{
    public class SceneInitializationInstaller : MonoInstaller
    {
        [SerializeField] private List<MonoInitializer> _initializers;

        public override void InstallBindings()
        {
            foreach (var initializer in _initializers)
                Container.Bind<IInitializable>().FromInstance(initializer).AsSingle();
        }
    }
}