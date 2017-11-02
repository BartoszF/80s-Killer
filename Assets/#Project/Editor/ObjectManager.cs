using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ObjectManager : EditorWindow {

    [MenuItem("80s Killer/Object Manager")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(ObjectManager));
    }

    void OnGUI()
    {
        // The actual window code goes here
    }
}
