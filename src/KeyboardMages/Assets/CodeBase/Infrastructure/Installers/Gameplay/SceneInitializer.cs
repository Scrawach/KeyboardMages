using CodeBase.Gameplay.Features.Cameras.Services;
using CodeBase.Infrastructure.Installers.Common;
using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure.Installers.Gameplay
{
    public class SceneInitializer : MonoInitializer
    {
        private ICameraProvider _cameraProvider;

        [Inject]
        public void Construct(ICameraProvider provider)
        {
            _cameraProvider = provider;
        }
        
        public override void Initialize()
        {
            _cameraProvider.SetupCamera(Camera.main);
        }
    }
}