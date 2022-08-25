using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public GameObject player;

    public NavMeshAgent myAgent;

    public int range;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Chequeo distancia del player
        float dist = Vector3.Distance(this.transform.position, player.transform.position);

        if (dist < range)
        {
            myAgent.destination = player.transform.position;
        }
    }
}