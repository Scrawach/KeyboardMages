using Entitas;

namespace CodeBase.Gameplay.Features.Hero.Systems
{
    public class SetMovingByAxisInput : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _heroes;
        private readonly IGroup<InputEntity> _inputs;

        public SetMovingByAxisInput(GameContext game, InputContext input)
        {
            _heroes = game.GetGroup(GameMatcher.Hero);
            
            _inputs = input.GetGroup(InputMatcher.Input);
        }

        public void Execute()
        {
            foreach (var input in _inputs)
            foreach (var hero in _heroes)
                hero.isMoving = input.hasAxisInput;
        }
    }
}