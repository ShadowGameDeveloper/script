using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveing : MonoBehaviour
{
    string tag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //動き関数
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.forward * 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward * -0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right * 0.1f);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right * -0.1f);

        }
    }
    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 250, 150), "Interaction");
        if (Input.GetKey(KeyCode.W))
        {
            GUI.Label(new Rect(120,40,40,20),
            "前");
        }
        if (Input.GetKey(KeyCode.S))
        {
            GUI.Label(new Rect(120, 110, 40, 30),
             "後ろ");
        }
        if (Input.GetKey(KeyCode.D))
        {
            GUI.Label(new Rect(200, 70, 40, 20),
             "左");

        }
        if (Input.GetKey(KeyCode.A))
        {
            GUI.Label(new Rect(30, 70, 40, 20),
             "右");
        }
    }
}
