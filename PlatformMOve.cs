using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMOve : MonoBehaviour
{
    public GameObject plat;
    Vector3 orginal;
    // Start is called before the first frame update
    void Start()
    {
        orginal = plat.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        ;
        if (this.gameObject.tag == "PlatformZ")
        {
            Debug.Log("Enter Collison Z");
            plat.transform.position += new Vector3(0.0f, 0.0f, 0.1f);
            if (plat.transform.position.z > 17.0f)
            {
                plat.transform.Translate(new Vector3(0.0f, 0.0f, 0.1f));
            }
            if (plat.transform.position.z < 1.5f)
            {
                plat.transform.position += new Vector3(0.0f, 0.0f, 0.1f);
            }
        }
        if (this.gameObject.tag == "plaformX")
        {
            Debug.Log("Enter Collison X");
            plat.transform.Translate(0.1f, 0.0f, 0.0f);
        }

        
    }

    private void OnTriggerExit(Collider other)
    {
       // plat.transform.position = orginal;
    }
}
