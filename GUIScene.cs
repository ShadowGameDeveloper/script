using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIScene : MonoBehaviour
{
    public Canvas canvas;
    public Text text;
    public Toggle toggle;
    public Slider slider;

    int msg_x = 0;
    int dx = 1;
    int count = 0;

    string msg = "";

    float slid_value = 0;

    bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        //canvasを隠します
        canvas.enabled = false;
        text.text = "Ready.....";
    }

    // Update is called once per frame
    void Update()
    {
        //スペースキー押せばcanvasを表示します
        if (Input.GetKey(KeyCode.Space))
        {
            canvas.enabled = true;
        }
    }

    public void onButtonClick()
    {
        //GUIボタン押せば
        text.text = "ok!!";
    }
    public void onToggleChange()
    {
        //GUI　toggle　変わる時
        text.text = toggle.isOn ? "ON" : "off"; 
    }
    public void OnSliderChange()
    {
        //GUI　slider　変わる時
        text.text = "value" + slider.value;
    }

    private void OnGUI()
    {
        //this.msg_x += this.dx;

        /*if(this.msg_x > 200 || this.msg_x < 0)
        {
            dx *= -1;
        }*/

        //GUIボタン作ります
        /*if(GUI.Button(new Rect(100,100,100,25),"add count"))
        {
            this.count++;
        }*/
        //GUItoggleボタン
        //this.flag = GUI.Toggle(new Rect(100, 100, 100, 25), this.flag, "Toggle");
        GUI.Box(new Rect(this.msg_x, 10, 350, 150), "Hello");
        //GUI　slider
        //this.slid_value = GUI.HorizontalSlider(new Rect(100, 100, 100, 25), this.slid_value, 0, 100);
        //GUI　text
        this.msg = GUI.TextField(new Rect(100, 100, 100, 25), this.msg);
        GUI.Label (new Rect(this.msg_x, 60, 300, 50), "「" + this.msg +"」と書きました。");
    }
}
