using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject impactEffect;
    public float damage = 25f;

    void OnCollisionEnter(Collision collision)

    {

        ContactPoint contact = collision.contacts[0];

        Instantiate(impactEffect, contact.point, Quaternion.LookRotation(contact.normal));

        if (collision.gameObject.tag == "Enemy")

        {

            Target target = collision.transform.gameObject.GetComponent<Target>();

            target.ApplyDamage(damage);

        }

        Destroy(gameObject);

        if (collision.gameObject.tag == "Player")

        {

            Target target = collision.transform.gameObject.GetComponent<Target>();

            target.ApplyDamage(damage);

        }

        Destroy(gameObject);

    }
}
