using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIMode : MonoBehaviour
{
    public GUIStyle textStyle;
    public GUIStyle buttonStyle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI()
    {
        GUI.Label(new Rect(50, 50, 50, 50), "Hello", textStyle);
        GUI.Button(new Rect(50, 100, 50, 50), "World", buttonStyle);

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
