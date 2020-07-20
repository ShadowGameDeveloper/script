using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyPress : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        int[] arr = { 0, 1, 2, 3, 4, 5 };

        foreach(int i in arr)
        {
            //２の時何もプリントしません
            if (i == 2) continue;
            //３のとき終わります
            else if (i == 3) break;

            Debug.Log(i);
        }
    }
}
