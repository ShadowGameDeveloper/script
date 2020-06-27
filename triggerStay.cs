using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerStay : MonoBehaviour
{

    public GameObject platform;

    private void OnTriggerStay(Collider other)
    {
        //if (platform.transform.position.y <= 10.0f) { };
        platform.transform.position += new Vector3(0.0f,0.01f,0.0f);
    }
}
