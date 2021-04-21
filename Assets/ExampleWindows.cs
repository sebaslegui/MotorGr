using UnityEngine;
using UnityEditor;

public class ExampleWindows : EditorWindow
{
    Color color;

    [MenuItem("Ventana/Color")]
   public static void ShowWindow ()
    {
        GetWindow<ExampleWindows>("Color");
    }
    void OnGUI()
    {
        GUILayout.Label("Seccion para insertar color.", EditorStyles.boldLabel);

        color = EditorGUILayout.ColorField("Color", color);

        if (GUILayout.Button("INSERTAR COLOR"))
        {
            foreach (GameObject obj in Selection.gameObjects)
            {
                Renderer renderer = obj.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.sharedMaterial.color = color;
                }
            }
           
        }
    }


 

}
