using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movingBall : MonoBehaviour
{
    public Text minss, sec;
    float timerS, timerM;
    string tagss;
    // Start is called before the first frame update
    void Start()
    {
        timerS = 0;
        timerM = 0;
        Rigidbody rb;
        rb = this.gameObject.GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePosition;
        rb.constraints = RigidbodyConstraints.FreezeRotation;

       
    }

    // Update is called once per frame
    void Update()
    {
        
        if(tagss == " ")
        {
            //タイマー始まります
            timerS += Time.deltaTime;
        }
        
        if(timerS >= 59)
        {
            //タイマーは分と秒分けます
            //６０秒1分
            timerS = 0;
            timerM += 1;
        }

        minss.text = timerM.ToString();
        sec.text = Mathf.Round(timerS).ToString();

        //ボールの動き方
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.up * 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.up * -0.1f);
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

    private void OnTriggerEnter(Collider other)
    {
        //スタートオブジェクトぶつかるとstartメッセージ表します
        if (other.gameObject.CompareTag("start"))
        {
            tagss = "start"; 
        }
        //終わるォジェクトぶつかるとendメッセージ表します
        if (other.gameObject.CompareTag("end"))
        {
            tagss = "end";
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        tagss = " ";
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            tagss = "wall";
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        tagss = " ";
    }

    private void OnGUI()
    {
        //オブジェクトをぶつかるとタイマーが一時停止
        if(tagss == "start")
        {
            GUI.Box(new Rect(0, 0, 100 , 50), "START");
            GUI.Box(new Rect(0, 80, 100, 50), timerM + " : " +Mathf.Round(timerS).ToString());
        }
        if (tagss == "end")
        {
            GUI.Box(new Rect(0, 0, 100, 50), "END");
            GUI.Box(new Rect(0, 80, 100, 50), timerM + " : " + Mathf.Round(timerS).ToString());
        }
        if (tagss == "wall")
        {
            GUI.Box(new Rect(0, 0, 100, 50), "STOP");
            GUI.Box(new Rect(0, 80, 100, 50), timerM + " : " + Mathf.Round(timerS).ToString());
        }
        if (tagss == " ")
        {
            GUI.Box(new Rect(0, 0, 100, 50), " ");
            GUI.Box(new Rect(0, 80, 100, 50), timerM + " : " + Mathf.Round(timerS).ToString());
        }
    }
}
