using UnityEditor;
using UnityEngine;

namespace FuckingSingletons.ScriptableObjects.Events
{
    [CustomEditor(typeof(SOEvent), editorForChildClasses: true)]
    public class SOEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            SOEvent e = target as SOEvent;
            if (GUILayout.Button("Raise"))
                e.Raise();
        }
    }
}
