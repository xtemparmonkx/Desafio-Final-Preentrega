using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    [SerializeField]
    protected EnemyData enemyData;
    public Transform player;
    public LayerMask whatIsGround, whatIsPlayer;    
    //public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;
    public Transform[] waypoints;

    NavMeshAgent agent;
    int waypointIndex;
    Vector3 target;
    // Start is called before the first frame update

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target) < 1)
        {
            IterateWaypointIndex();
            UpdateDestination();
        }

        {
            playerInSightRange = Physics.CheckSphere(transform.position, enemyData.sightRange, whatIsPlayer);
            playerInAttackRange = Physics.CheckSphere(transform.position, enemyData.attackRange, whatIsPlayer);            
        }
    }

    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }

    private void IterateWaypointIndex()
    {
        waypointIndex++;
        if (waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
    }
}
