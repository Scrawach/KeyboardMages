using UnityEngine;

namespace CodeBase.Gameplay.Features.Cameras.Services
{
    public class CameraProvider : ICameraProvider
    {
        public Camera MainCamera { get; private set; }
        
        public void SetupCamera(Camera camera) => 
            MainCamera = camera;
    }
}