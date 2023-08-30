using UnityEditor;
using UnityEngine;

public class PmEditorWindow : EditorWindow
{
 
    
    [MenuItem("PlayMaker/Addons/Ecosystem/Upm Package test")]
    public static void ShowWindow()
    {
        //Show existing window instance. If one doesn't exist, make one.
        EditorWindow.GetWindow(typeof(PmEditorWindow));
    }
    
    void OnGUI()
    {
        GUILayout.Label ("Success you have v1.1.0", EditorStyles.boldLabel);
        PmUtils.UtilsTest();
        
    }
}