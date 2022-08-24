using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxEstado1: MonoBehaviour
{
    //---------------------- PROPIEDADES SERIALIZADAS ----------------------

    [SerializeField] GameObject nuevoEstado;
    
    //---------------------- PROPIEDADES PRIVADAS ----------------------


    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "bullet")                
        {
            Instantiate(nuevoEstado, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
                
        }
    }
}
