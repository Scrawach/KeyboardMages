using UnityEngine;

namespace CodeBase.Gameplay.Levels
{
    public interface ILevelDataProvider
    {
        Vector3 StartPoint { get; set; }
    }
}