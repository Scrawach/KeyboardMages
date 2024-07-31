using UnityEngine;

namespace CodeBase.Inputs.Service
{
    public interface IInput
    {
        bool HasAxis { get; }
        Vector2 Axis { get; }
    }
}