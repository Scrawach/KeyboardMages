using CodeBase.Inputs.Service;
using Entitas;

namespace CodeBase.Inputs.Systems
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