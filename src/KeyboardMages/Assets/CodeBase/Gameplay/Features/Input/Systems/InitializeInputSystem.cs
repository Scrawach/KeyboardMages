using Entitas;

namespace CodeBase.Gameplay.Features.Input.Systems
{
    public class InitializeInputSystem : IInitializeSystem
    {
        private readonly InputContext _context;

        public InitializeInputSystem(InputContext context) => 
            _context = context;

        public void Initialize() => 
            _context.CreateEntity().isInput = true;
    }
}