using UnityEditor;

namespace UI.Animation.Editor
{
	[CustomEditor(typeof(UITBackgroundClip))]
	public class UITBackgroundClipEditor : UnityEditor.Editor
	{
		private SerializedProperty backgroundImage;

		private void OnEnable()
		{
			backgroundImage = serializedObject.FindProperty("_template.BackgroundImage");
		}

		public override void OnInspectorGUI()
		{
			serializedObject.Update();
			EditorGUILayout.PropertyField(backgroundImage);
			serializedObject.ApplyModifiedProperties();
		}
	}
}