using UnityEngine;

namespace CodeBase.Gameplay.Features.Cameras.Services
{
    public interface ICameraProvider
    {
        Camera MainCamera { get; }
        void SetupCamera(Camera camera);
    }
}