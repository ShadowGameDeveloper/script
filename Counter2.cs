using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Sample(5, 0.5f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Sample(int num,float inter)
    {
        for(int i = 0; i < num; i++)
        {
            Debug.Log("i:" + i);

            yield return new WaitForSeconds(inter);
        }
    }
}
