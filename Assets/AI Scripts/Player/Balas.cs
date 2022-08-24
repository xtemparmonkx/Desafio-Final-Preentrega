using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balas : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "caja") // Si la bala colisiona con una caja, se destruye
        {
            Debug.Log("La bala colisionó con una caja");
            Destroy(this.gameObject);

        }

        if (collision.gameObject.tag == "bullet") // Si la bala colisiona con otra bala, se destruye
        {
            Debug.Log("La bala colisionó con una caja");
            Destroy(this.gameObject);
        }
    }
}
