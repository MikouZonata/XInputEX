using UnityEngine;
using UnityEditor;

namespace XInputDotNetExtended {

    [CustomPropertyDrawer(typeof(PlayerIndex))]
    public class PlayerIndexDrawer : PropertyDrawer
    {
        SerializedProperty playerIndex;

        public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
        {
            playerIndex = property.FindPropertyRelative("playerIndex");

            EditorGUI.PropertyField(position, playerIndex, label);
        }
    }

    [CustomPropertyDrawer(typeof(Button))]
    public class ButtonDrawer : PropertyDrawer
    {
        SerializedProperty button;

        public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
        {
           button = property.FindPropertyRelative("button");

           EditorGUI.PropertyField(position, button, label);
        }
    }

    [CustomPropertyDrawer(typeof(DirectionalInput))]
    public class DirectionalInputDrawer : PropertyDrawer
    {
        SerializedProperty directionalInput;

        public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
        {
            directionalInput = property.FindPropertyRelative("directionalInput");

            EditorGUI.PropertyField(position, directionalInput, label);
        }
    }

    [CustomPropertyDrawer(typeof(Trigger))]
    public class TriggerDrawer : PropertyDrawer
    {
        SerializedProperty trigger;

        public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
        {
            trigger = property.FindPropertyRelative("trigger");

            EditorGUI.PropertyField(position, trigger, label);
        }
    }

    [CustomPropertyDrawer(typeof(Direction))]
    public class DirectionDrawer : PropertyDrawer
    {
        SerializedProperty direction;

        public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
        {
            direction = property.FindPropertyRelative("direction");

            EditorGUI.PropertyField(position, direction, label);
        }
    }

    [CustomPropertyDrawer(typeof(Axis))]
    public class AxisDrawer : PropertyDrawer
    {
        SerializedProperty axis;

        public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
        {
            axis = property.FindPropertyRelative("axis");

            EditorGUI.PropertyField(position, axis, label);
        }
    }
}
