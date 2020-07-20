using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorsss2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //まず、changecolor1の関数を呼びます
        StartCoroutine("changeColor1");
    }

    IEnumerator changeColor1()
    {
        //オブジェクトは赤色に付きます
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        //1秒を待ちます
        yield return new WaitForSeconds(1);
        //changecolor2呼びます
        StartCoroutine("changeColor2");
    }

    IEnumerator changeColor2()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.blue;

        yield return new WaitForSeconds(1);

        gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }
}
