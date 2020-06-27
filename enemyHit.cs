using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyHit : MonoBehaviour
{
    Vector3 alien1;
    public GameObject player;
   // public GameObject check;

    // Start is called before the first frame update
    void Start()
    {
        //check = GetComponent<GameObject>();
        player = GetComponent<GameObject>();
        alien1 = this.gameObject.transform.position;
        Debug.Log(alien1.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void OnCollisionEnter(Collision collision)
    {
        Debug.Log("enemy Hit");
        this.gameObject.transform.position = alien1;
        collision.transform.position = check.transform.position;
    }*/
    private void OnTriggerEnter(Collider other)
    {
        /*Debug.Log("enemy Hit");
        this.gameObject.transform.position = alien1;
        player.transform.position = check.transform.position;*/
        SceneManager.LoadScene("gameOver");
    }

}
