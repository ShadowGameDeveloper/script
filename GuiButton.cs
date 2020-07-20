using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    void OnGUI()
    {
        /*GUI.Label(new Rect(50, 50, 50, 50), "Hello");
        GUI.Button(new Rect(50, 100, 50, 50), "World");*/
        //GUIボタン
        if(GUI.Button(new Rect(100, 100, 100, 100), "Hello"))
        {
            Debug.Log("Hello World");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
