using CodeBase.Gameplay.Features.Input.Service;
using UnityEngine;

namespace Tests.EditMode.Gameplay.Features.Input
{
    public class MockedInput : IInput
    {
        public MockedInput(bool hasAxis, Vector2 axis)
        {
            HasAxis = hasAxis;
            Axis = axis;
        }

        public bool HasAxis { get; set; }
        public Vector2 Axis { get; set; }
    }
}