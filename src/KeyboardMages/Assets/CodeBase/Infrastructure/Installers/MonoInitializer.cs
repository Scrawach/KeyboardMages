using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure.Installers
{
    public abstract class MonoInitializer : MonoBehaviour, IInitializable
    {
        public abstract void Initialize();
    }
}