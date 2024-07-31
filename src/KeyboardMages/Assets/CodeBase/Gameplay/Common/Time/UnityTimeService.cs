using System;

namespace CodeBase.Gameplay.Common.Time
{
    public class UnityTimeService : ITimeService
    {
        public float DeltaTime => UnityEngine.Time.deltaTime;
        public DateTime UtcNow => DateTime.Now;
    }
}