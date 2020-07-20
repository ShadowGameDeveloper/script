using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIArray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI()
    {
        //array作ります
        int[] data = { 98, 72, 63, 89, 56 };
        int total = 0;

        //data　array　の合計を計算
        foreach(int n in data)
        {

            total += n;
        }
        //平均を計算
        int ave = total / 5;
        Message("合計 = "+total+" 平均 = "+ave);
    }

    void Message(string msg)
    {
        //dataの平均はGUIに表示する
        GUI.Box(new Rect(10, 10, 350, 100), "Massage");
        GUI.Label(new Rect(35, 60, 300, 50), msg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
