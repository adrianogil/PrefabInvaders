using UnityEngine;
using System.Collections;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class GenerationTest : MonoBehaviour {

    public GameObject prefab;
    public TextAsset textAsset;

	// Use this for initialization
	void Start () {
	   Debug.Log("GenerationTest::Start - " + gameObject.GetInstanceID());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

[CustomEditor(typeof(GenerationTest))]
public class GenerationTestEditor : Editor {

    bool debugMode = false;

    public override void OnInspectorGUI()
    {
        debugMode = EditorGUILayout.Toggle("Debug mode", debugMode);

        if (debugMode)
        {
            base.OnInspectorGUI();  
        }
    }

}