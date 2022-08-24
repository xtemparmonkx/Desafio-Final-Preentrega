using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    public Vector3 EscalaMunicion = new Vector3(1, 1, 1);
    public Vector3 direction = new Vector3(0f, 0f, 1f);
    public float speed = 30f;
    public float TiempoDeVida = 4f;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destruccion", TiempoDeVida);
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
    }

    private void Mover()
    {
        transform.position += direction * speed * Time.deltaTime;
        transform.rotation = transform.rotation * Quaternion.Euler(0, 90, 0);
    }

    private void Destruccion()
    {
        Debug.Log("Se destruye la munición");
        Destroy(gameObject);
    }
}
