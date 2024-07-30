using UnityEngine;

namespace CodeBase.Infrastructure.Common.AssetManagement
{
    public interface IAssets
    {
        TAsset Load<TAsset>(string path) where TAsset : Object;
    }
}