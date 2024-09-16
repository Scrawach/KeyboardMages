using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

namespace CodeBase.Editor
{
    [InitializeOnLoad]
    public class AutoBootstrapSceneStartup
    {
        static AutoBootstrapSceneStartup() => 
            EditorSceneManager.playModeStartScene = GetBootstrapScene();

        private static SceneAsset GetBootstrapScene()
        {
            var path = SceneUtility.GetScenePathByBuildIndex(0);
            return AssetDatabase.LoadAssetAtPath<SceneAsset>(path);
        }
    }
}