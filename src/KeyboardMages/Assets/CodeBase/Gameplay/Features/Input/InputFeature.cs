using CodeBase.Gameplay.Features.Input.Systems;
using CodeBase.Infrastructure.Systems;

namespace CodeBase.Gameplay.Features.Input
{
    public class InputFeature : GenericFeature
    {
        public InputFeature(ISystemFactory systems) : base(systems)
        {
            Add<InitializeInputSystem>();
            Add<EmitInputSystem>();
        }
    }
}