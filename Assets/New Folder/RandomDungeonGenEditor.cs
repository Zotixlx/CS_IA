using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AbstractDungonGen), true)]
public class NewMonoBehaviourScript : Editor
{
    AbstractDungonGen generator;

    private void Awake()
    {
        generator = (AbstractDungonGen)target;
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Generate Dungeon"))
        {
            generator.GenerateDungeon();
        }
    }
}
