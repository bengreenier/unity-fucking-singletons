using UnityEditor;
using UnityEngine;

namespace FuckingSingletons.ScriptableObjects.Sets
{
    [CustomEditor(typeof(ScriptableObjectWithChildCount), editorForChildClasses: true, isFallback = true)]
    public class ScriptableObjectWithChildCountEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            ScriptableObjectWithChildCount e = target as ScriptableObjectWithChildCount;

            GUILayout.Label("Child count: " + e.GetChildCount());
        }
    }
}
