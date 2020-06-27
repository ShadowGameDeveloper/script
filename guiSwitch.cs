using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guiSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI()
    {
        int month = 1;
        string s = "「" + month + "月」は、";
        switch (month)
        {
            case 1:
                s += "睦月";
                break;
            case 2:
                s += "如月";
                break;
            case 3:
                s += "弥月";
                break;
            default:
                s += "なんだわからない";
                break;
        }
        s += "です";
        Message(s);
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
