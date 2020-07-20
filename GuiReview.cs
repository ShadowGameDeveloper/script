using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiReview : MonoBehaviour
{
    void OnGUI()
    {
        int num = 100;
        //numの階乗を精算します
        string msg = num + "の場合は" + Goukei(num) + "です";
        Message(msg);
    }

    // Start is called before the first frame update
    void Message(string msg)
    {
        GUI.Box(new Rect(10, 10, 350, 100), "Massage");
        GUI.Label(new Rect(35, 60, 300, 50), msg);
    }

    int Goukei(int n)
    {
        //階乗を精算する関数
        int total = 0;
        for(int i = 1; i<= n; i++)
        {
            total += i;
        }
        return total;
    }
}
