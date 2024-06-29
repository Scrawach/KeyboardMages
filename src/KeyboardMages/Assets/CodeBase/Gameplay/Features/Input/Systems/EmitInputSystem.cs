using CodeBase.Gameplay.Features.Input.Service;
using Entitas;

namespace CodeBase.Gameplay.Features.Input.Systems
{
    public class EmitInputSystem : IExecuteSystem
    {
        private readonly IInput _input;
        private readonly IGroup<InputEntity> _inputs;

        public EmitInputSystem(InputContext input, IInput inputService)
        {
            _input = inputService;
            _inputs = input.GetGroup(InputMatcher.Input);
        }

        public void Execute()
        {
            foreach (var input in _inputs)
            {
                if (_input.HasAxis)
                    input.ReplaceAxisInput(input.AxisInput);
                else if (input.hasAxisInput)
                    input.RemoveAxisInput();
            }
        }
    }
}