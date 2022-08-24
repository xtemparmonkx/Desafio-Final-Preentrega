using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activador2 : MonoBehaviour
{
    //---------------------- PROPIEDADES SERIALIZADAS ---------------------


    [SerializeField] GameObject Escudo1;
    [SerializeField] Vector3 direction = new Vector3(0f, -1f, 0f);
    [SerializeField] int speed = 6;
    [SerializeField] GameObject Camera;
    [SerializeField] AudioSource MagicAudio;
    [SerializeField] int TiempoEspera = 4;


    //---------------------- PROPIEDADES PRIVADAS ----------------------

        private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CajaActivadora")
        {
            MagicAudio.Play();
            Camera.SetActive(true);
            Invoke("apagarCamera", TiempoEspera);
            Invoke("Destruction", TiempoEspera);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "CajaActivadora")
        {
            desactivarEscudo();   
        }
    }

    private void desactivarEscudo()
    {
        Escudo1.transform.position += direction * speed * Time.deltaTime;
    }

    private void apagarCamera()
    {
        Camera.SetActive(false);
    }

    private void Destruction()
    {
        Escudo1.SetActive(false);
    }
}
