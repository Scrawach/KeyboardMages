using UnityEngine;

namespace CodeBase.Gameplay.Features.Input.Service
{
    public interface IInput
    {
        bool HasAxis { get; }
        Vector2 Axis { get; }
    }
}