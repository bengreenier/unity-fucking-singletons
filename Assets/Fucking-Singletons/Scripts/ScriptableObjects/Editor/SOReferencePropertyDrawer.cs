using FuckingSingletons.ScriptableObjects.Primitives;
using UnityEditor;
using UnityEngine;

namespace FuckingSingletons.ScriptableObjects
{
    [CustomPropertyDrawer(typeof(SOBoolReference))]
    [CustomPropertyDrawer(typeof(SOFloatReference))]
    [CustomPropertyDrawer(typeof(SOIntReference))]
    [CustomPropertyDrawer(typeof(SOStringReference))]
    public class SOReferencePropertyDrawer : PropertyDrawer
    {
        /// <summary> Cached style to use to draw the popup button. </summary>
        private GUIStyle popupStyle;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (popupStyle == null)
            {
                popupStyle = new GUIStyle(GUI.skin.GetStyle("PaneOptions"));
                popupStyle.imagePosition = ImagePosition.ImageOnly;
            }

            EditorGUI.BeginProperty(position, label, property);
            
            // draw label
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            
            // calculate rects
            var dropdownRect = new Rect(position.x - (popupStyle.fixedWidth + popupStyle.margin.right), position.y, popupStyle.fixedWidth + popupStyle.margin.right, position.height);
            var valueRect = new Rect(position.x, position.y, position.width, position.height);

            var useConstantProp = property.FindPropertyRelative("UseConstant");
            var selection = EditorGUI.Popup(dropdownRect, useConstantProp.boolValue ? 0 : 1, new string[] { "Constant", "Object" }, popupStyle);

            // logic for swapping constant and object
            if (selection == 1 && useConstantProp.boolValue)
            {
                Debug.Log("swap to !constant");
                useConstantProp.boolValue = false;
            }
            else if (selection == 0 && !useConstantProp.boolValue)
            {
                Debug.Log("swap to constant");
                useConstantProp.boolValue = true;
            }

            // logic for rendering the field
            if (useConstantProp.boolValue)
            {
                EditorGUI.PropertyField(valueRect, property.FindPropertyRelative("Constant"), GUIContent.none);
            }
            else
            {
                EditorGUI.PropertyField(valueRect, property.FindPropertyRelative("SOObject"), GUIContent.none);
            }
            
            EditorGUI.EndProperty();
        }
    }
}