using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxhealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int ammount)
    {
        health -= ammount;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
