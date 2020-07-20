using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counters : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //sample関数を始まります
        StartCoroutine("sample", 234);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator sample(int num)
    {

        for( int i = 0; i < num; i++)
        {
            Debug.Log("i:" + i);
            yield return null;
        }
    }
}
