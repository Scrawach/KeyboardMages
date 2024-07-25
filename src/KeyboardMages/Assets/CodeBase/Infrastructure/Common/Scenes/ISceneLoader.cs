using System;

namespace CodeBase.Infrastructure.Common.Scenes
{
    public interface ISceneLoader
    {
        void Load(string sceneName, Action onLoaded = null);
    }
}