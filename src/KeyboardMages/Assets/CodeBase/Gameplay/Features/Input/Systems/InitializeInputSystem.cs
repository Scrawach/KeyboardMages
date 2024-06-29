using CodeBase.Common.Entities;
using Entitas;

namespace CodeBase.Gameplay.Features.Input.Systems
{
    public class InitializeInputSystem : IInitializeSystem
    {
        public void Initialize() => 
            CreateInputEntity.Empty()
                .isInput = true;
    }
}