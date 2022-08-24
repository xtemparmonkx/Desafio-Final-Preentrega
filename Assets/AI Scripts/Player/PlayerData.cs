using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public float startHealth;
    private float hp;

    public GameObject Explode;

    void Start()
    {
        hp = startHealth;
    }

    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        hp -= damage;
        if(hp <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        if (Explode != null)
        {
            Instantiate(Explode, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
