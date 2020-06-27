using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorsss2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("changeColor1");
    }

    IEnumerator changeColor1()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;

        yield return new WaitForSeconds(1);
        
        StartCoroutine("changeColor2");
    }

    IEnumerator changeColor2()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.blue;

        yield return new WaitForSeconds(1);

        gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }
}
