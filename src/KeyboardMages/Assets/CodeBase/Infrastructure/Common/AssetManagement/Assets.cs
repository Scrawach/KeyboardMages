using System.Collections.Generic;
using UnityEngine;

namespace CodeBase.Infrastructure.Common.AssetManagement
{
    public class Assets : IAssets
    {
        public TAsset Load<TAsset>(string path) where TAsset : Object => 
            Resources.Load<TAsset>(path);

        public IEnumerable<TAsset> LoadAll<TAsset>(string path) where TAsset : Object => 
            Resources.LoadAll<TAsset>(path);
    }
}