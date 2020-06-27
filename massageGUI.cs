using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class massageGUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI()
    {
        Message("こんにちは");
    }

    void Message(string msg)
    {
        GUI.Box(new Rect(10, 10, 350, 100), "Massage");
        GUI.Label(new Rect(35, 60, 300, 50), msg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
