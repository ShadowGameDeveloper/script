using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class pathMove : MonoBehaviour
{
    [SerializeField] Transform tar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //navmesh通り、ターゲット探します
        GetComponent<NavMeshAgent>().destination = tar.transform.position;
    }
}
