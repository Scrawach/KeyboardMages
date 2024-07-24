using CodeBase.Gameplay;
using CodeBase.Infrastructure.Systems;
using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure
{
    public class EcsRunner : MonoBehaviour
    {
        private ISystemFactory _systems;
        private GameplayFeature _gameplay;

        [Inject]
        public void Construct(ISystemFactory systems) => 
            _systems = systems;

        private void Start()
        {
            _gameplay = _systems.Create<GameplayFeature>();
            _gameplay.Initialize();
        }

        private void Update()
        {
            _gameplay.Execute();
            _gameplay.Cleanup();
        }

        private void OnDestroy() => 
            _gameplay.TearDown();
    }
}