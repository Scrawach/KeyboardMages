using CodeBase.Gameplay.Features.Cameras.Services;
using CodeBase.Gameplay.Levels;
using CodeBase.Infrastructure.Installers.Common;
using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure.Installers.Gameplay
{
    public class SceneInitializer : MonoInitializer
    {
        [SerializeField] private Transform _startPoint;
        
        private ICameraProvider _cameraProvider;
        private ILevelDataProvider _levelDataProvider;

        [Inject]
        public void Construct(ICameraProvider cameraProvider, ILevelDataProvider levelDataProvider)
        {
            _cameraProvider = cameraProvider;
            _levelDataProvider = levelDataProvider;
        }
        
        public override void Initialize()
        {
            _cameraProvider.SetupCamera(Camera.main);
            _levelDataProvider.StartPoint = _startPoint.position;
        }
    }
}