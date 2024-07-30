using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure.Installers.Common
{
    public abstract class MonoInitializer : MonoBehaviour, IInitializable
    {
        public abstract void Initialize();
    }
}