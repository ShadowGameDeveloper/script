using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countGUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI()
    {
        int x = 100;
        int y = 200;
        int z = x + y;
        Message("答え = " + z);
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
