// ------------------------------------------- //
// Author  : William Whitehouse / WSWhitehouse //
// GitHub  : github.com/WSWhitehouse           //
// Created : 09/02/2020                        //
// Edited  : 10/02/2020                        // 
// ------------------------------------------- //

using System;
using UnityEditor;
using UnityEngine;

namespace WSWhitehouse.UniqueID.Editor
{
    [CustomEditor(typeof(UniqueID))]
    public class UniqueIDEditor : UnityEditor.Editor
    {
        private UniqueID _uniqueID;
        private SerializedProperty _id;

        public override void OnInspectorGUI()
        {
            _uniqueID = (UniqueID) target;

            _id = serializedObject.FindProperty("id");

            if (string.IsNullOrEmpty(_id.stringValue))
            {
                ResetUniqueID();
            }

            EditorGUILayout.BeginHorizontal(GUI.skin.box);
            EditorGUILayout.LabelField(new GUIContent("Unique ID"), EditorStyles.boldLabel);
            EditorGUILayout.LabelField(new GUIContent(_uniqueID.ID));
            EditorGUILayout.EndHorizontal();

            if (GUILayout.Button(new GUIContent("Reset ID")) && EditorUtility.DisplayDialog("Reset ID",
                    "Are you sure you want to reset the ID? You cannot change it back!", "Reset ID", "Cancel"))
            {
                ResetUniqueID();
            }
        }

        private void ResetUniqueID()
        {
            Debug.Log(_uniqueID.gameObject.name + " :: RESETTING UNIQUE ID");
            _id.stringValue = Guid.NewGuid().ToString();
            EditorUtility.SetDirty(_uniqueID.gameObject);
            serializedObject.ApplyModifiedProperties();
        }
    }
}