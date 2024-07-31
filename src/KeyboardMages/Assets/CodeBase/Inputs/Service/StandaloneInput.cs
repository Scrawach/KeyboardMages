using UnityEngine;

namespace CodeBase.Inputs.Service
{
    public class StandaloneInput : IInput
    {
        private const string HorizontalAxis = "Horizontal";
        private const string VerticalAxis = "Vertical";

        public bool HasAxis => Axis != Vector2.zero;

        public Vector2 Axis =>
            new Vector2(
                x: UnityEngine.Input.GetAxis(HorizontalAxis), 
                y: UnityEngine.Input.GetAxis(VerticalAxis));
    }
}