using CodeBase.Gameplay.Common.Time;
using Entitas;

namespace CodeBase.Gameplay.Features.Movement.Systems
{
    public class DirectionalDeltaMoveSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _movers;
        private readonly ITimeService _time;

        public DirectionalDeltaMoveSystem(GameContext game, ITimeService time)
        {
            _movers = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.WorldPosition,
                    GameMatcher.Direction,
                    GameMatcher.Speed,
                    GameMatcher.Moving));
            _time = time;
        }

        public void Execute()
        {
            foreach (var mover in _movers)
            {
                var movement = mover.Direction * mover.Speed * _time.DeltaTime;
                var targetPosition = mover.WorldPosition + movement;

                mover.ReplaceWorldPosition(targetPosition);
            }
        }
    }
}