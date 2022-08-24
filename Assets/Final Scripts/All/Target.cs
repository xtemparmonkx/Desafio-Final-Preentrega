using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 100f;
    public float damage = 25f;    

    public void ApplyDamage(float amount)
    {
        health -= Mathf.Abs(amount);
        if (health <= 0)
        {            
            Die();
        }

    }

    void Die()
    {
        Destroy(gameObject);
    }
}
