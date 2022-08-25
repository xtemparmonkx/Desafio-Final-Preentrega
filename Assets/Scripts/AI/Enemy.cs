using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    enum SpiderTypes { Stalker, Rioter};
    [SerializeField] SpiderTypes spiderType;

    [SerializeField] Transform playerTransform;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (spiderType)
        {
            case SpiderTypes.Stalker:
                //Debug.Log("Enemy stalker");
                Chase();
                break;
            case SpiderTypes.Rioter:
                //Debug.Log("Enemy rioter");
                LookPlayer();
                break;
        }
    }

    private void Chase()
    {
        LookPlayer();
        Vector3 direction = (playerTransform.position - transform.position);
        if (direction.magnitude > 5f)
        {
            transform.position += direction.normalized * speed * Time.deltaTime;
        }
        
    }

    private void LookPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation(playerTransform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 1.5f * Time.deltaTime);
    }
}
