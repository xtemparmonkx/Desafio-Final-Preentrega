using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    //---------------------- PROPIEDADES SERIALIZADAS ----------------------

    [SerializeField] GameObject impactEffect;
    [SerializeField] float damage = 25f;

    //---------------------- PROPIEDADES PRIVADAS ----------------------

    void OnCollisionEnter(Collision collision)

    {

        ContactPoint contact = collision.contacts[0];

        Instantiate(impactEffect, contact.point, Quaternion.LookRotation(contact.normal));

        if (collision.gameObject.tag == "Enemy")

        {

            Health target = collision.transform.gameObject.GetComponent<Health>();

            target.ApplyDamage(damage);

        }

        Destroy(gameObject);

        if (collision.gameObject.tag == "Player")

        {

            Health target = collision.transform.gameObject.GetComponent<Health>();

            target.ApplyDamage(damage);

        }

        Destroy(gameObject);

    }
}
