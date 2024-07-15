using CodeBase.Gameplay.Features.Input.Service;
using Entitas;

namespace CodeBase.Gameplay.Features.Input.Systems
{
    public class EmitInputSystem : IExecuteSystem
    {
        private readonly IInput _inputService;
        private readonly IGroup<InputEntity> _inputs;

        public EmitInputSystem(InputContext input, IInput inputService)
        {
            _inputService = inputService;
            _inputs = input.GetGroup(InputMatcher.Input);
        }

        public void Execute()
        {
            foreach (var input in _inputs)
            {
                if (_inputService.HasAxis)
                    input.ReplaceAxisInput(_inputService.Axis);
                else if (input.hasAxisInput)
                    input.RemoveAxisInput();
            }
        }
    }
}