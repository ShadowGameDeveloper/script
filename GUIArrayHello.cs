using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIArrayHello : MonoBehaviour
{
    enum Hello { Hello, Welcome, Chao };
    // Start is called before the first frame update
    void OnGUI()
    {
        Hello h = Hello.Chao;
        switch (h)
        {
            case Hello.Hello:
                Message("ハロー");
                break;
            case Hello.Welcome:
                Message("ようこそ！");
                break;
            case Hello.Chao:
                Message("チャオ。");
                break;
        }
    }

    void Message(string msg)
    {
        GUI.Box(new Rect(10, 10, 350, 100), "Massage");
        GUI.Label(new Rect(35, 60, 300, 50), msg);
    }
}
