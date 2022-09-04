using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Final : MonoBehaviour
{
    public Transform Player;
    public float Distance;
    public float SpeedRotation;
    public float stopDistance;
    public UnityEngine.AI.NavMeshAgent Enemy;

    RaycastHit objectHit;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector3.Distance(transform.position, Player.transform.position) < Distance)
        {
            Enemy.SetDestination(Player.transform.position);
            Vector3 lTargetDir = Player.position - transform.position;
            lTargetDir.y = stopDistance;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(lTargetDir), Time.time * SpeedRotation);
        }
        
    }
   
}
