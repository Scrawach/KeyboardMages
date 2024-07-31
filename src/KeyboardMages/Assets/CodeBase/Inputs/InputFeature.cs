using CodeBase.Infrastructure.Systems;
using CodeBase.Inputs.Systems;

namespace CodeBase.Inputs
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