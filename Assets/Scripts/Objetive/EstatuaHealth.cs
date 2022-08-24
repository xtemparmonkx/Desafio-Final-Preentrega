using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstatuaHealth : MonoBehaviour
{
    //---------------------- PROPIEDADES SERIALIZADAS ---------------------

    [SerializeField] int vidaObjetivo = 10;
    [SerializeField] AudioSource AudioImpacto;
    [SerializeField] GameObject efectoFX;

    [SerializeField] GameObject Camera;
    [SerializeField] int TiempoEspera = 5;
    [SerializeField] int TiempoEspera2 = 8;


    [SerializeField] GameObject puerta;
    [SerializeField] GameObject estatua;


    [SerializeField] Vector3 direction = new Vector3(0f, -1f, 0f);
    [SerializeField] int speed = 6;


    //---------------------- PROPIEDADES PRIVADAS -------------------------

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            AudioImpacto.Play();
            vidaObjetivo = vidaObjetivo - 1;
            Debug.Log("Al enemigo le queda " + vidaObjetivo + " de vida");

            if (vidaObjetivo <= 0)
            {
                Invoke("caidaEstatua", TiempoEspera);
                Camera.SetActive(true);
                Invoke("activarExit", TiempoEspera);
                Invoke("Destruction", TiempoEspera);
                Invoke("apagarCamera", TiempoEspera2);
            }
        }
    }

    private void activarExit()
    {
        puerta.transform.position += direction * speed * Time.deltaTime;
    }

    private void caidaEstatua()
    {
        estatua.transform.position += direction * speed * Time.deltaTime;
    }

    private void Destruction()
    {
        puerta.SetActive(false);
        estatua.SetActive(false);
    }

    private void apagarCamera()
    {
        Camera.SetActive(false);
    }
}
