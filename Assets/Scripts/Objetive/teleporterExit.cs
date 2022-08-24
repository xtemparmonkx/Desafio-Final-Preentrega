using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporterExit : MonoBehaviour
{
    [SerializeField] private float cooldown = 2f;

    [SerializeField] Transform nextPortal;

    [SerializeField]

    private float timeInPortal = 0f;

    private void OnTriggerEnter(Collider other)
    {
        timeInPortal = 0;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("estoy dentro del trigger");
            timeInPortal += Time.deltaTime;
            if (timeInPortal > cooldown)
            {
                other.transform.position = nextPortal.position;
                other.transform.rotation = other.transform.rotation * Quaternion.Euler(0, 0, 0);
            }
        }
    }
}

