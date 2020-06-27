using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControl : MonoBehaviour
{
    public GameObject CubeMaster;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0;i < 20; i++)
        {
            for(int j = 0; j < 20; j++)
            {
                Instantiate(CubeMaster, new Vector3(i, 0, j), Quaternion.identity);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
