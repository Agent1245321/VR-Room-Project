using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Follow : MonoBehaviour
{
    public Vector3 pos;
    public GameObject player;

    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = player.transform.position;
        agent.SetDestination(pos);
    }
}
