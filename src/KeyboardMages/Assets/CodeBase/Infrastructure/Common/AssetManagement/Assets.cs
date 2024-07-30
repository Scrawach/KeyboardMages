using UnityEngine;

namespace CodeBase.Infrastructure.Common.AssetManagement
{
    public class Assets : IAssets
    {
        public TAsset Load<TAsset>(string path) where TAsset : Object => 
            Resources.Load<TAsset>(path);
    }
}