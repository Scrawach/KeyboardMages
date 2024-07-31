using Entitas;

namespace CodeBase.Gameplay.Features.Hero.Systems
{
    public class SetHeroDirectionByInputSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _heroes;
        private readonly IGroup<InputEntity> _inputs;

        public SetHeroDirectionByInputSystem(GameContext game, InputContext input)
        {
            _heroes = game.GetGroup(GameMatcher.Hero);
            
            _inputs = input.GetGroup(InputMatcher
                .AllOf(
                    InputMatcher.Input, 
                    InputMatcher.AxisInput));
        }

        public void Execute()
        {
            foreach (var input in _inputs)
            foreach (var hero in _heroes)
                hero.ReplaceDirection(input.AxisInput.normalized);
        }
    }
}