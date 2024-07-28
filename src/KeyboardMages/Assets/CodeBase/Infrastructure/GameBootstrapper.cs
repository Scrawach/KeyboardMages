using CodeBase.Infrastructure.Common.Scenes;
using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure
{
    public class GameBootstrapper : MonoBehaviour
    {
        private ISceneLoader _sceneLoader;

        [Inject]
        public void Construct(ISceneLoader loader) => 
            _sceneLoader = loader;

        public void Start() => 
            _sceneLoader.Load(SceneNames.Gameplay);
    }
}