using System.Collections.Generic;
using CodeBase.Infrastructure.Common.Scenes;
using CodeBase.Infrastructure.Common.StaticData;
using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure
{
    public class GameBootstrapper : MonoBehaviour
    {
        private ISceneLoader _sceneLoader;
        private IEnumerable<IStaticDataLoader> _staticDataLoaders;

        [Inject]
        public void Construct(ISceneLoader sceneLoader, IEnumerable<IStaticDataLoader> staticDataLoaders)
        {
            _sceneLoader = sceneLoader;
            _staticDataLoaders = staticDataLoaders;
        }

        public void Start()
        {
            _sceneLoader.Load(SceneNames.Gameplay);

            foreach (var staticDataLoader in _staticDataLoaders) 
                staticDataLoader.Load();
        }
    }
}