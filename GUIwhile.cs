using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIwhile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI()
    {
        //while ver.
        /*int max = 123;
        int total = 0;
        int count = 0;

        while(count <= max)
        {
            total += count++;
        }
        Message("合計" + total);*/

        //for ver.
        int max = 100;
        int total = 0;


        for(int i = 1; i <= max; i++)
        {
            total += i;
        }
        Message("合計" + total);
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
