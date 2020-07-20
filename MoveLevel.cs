using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //ぶつかるとオブジェクトのタッグを比べます
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("level 2");
        }
    }
}
