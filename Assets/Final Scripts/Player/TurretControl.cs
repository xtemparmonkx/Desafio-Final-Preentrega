using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControl : MonoBehaviour
{
    
    public float cameraAxisX = 0f;
    public float cameraAxisY = 0f;
    public GameObject cannon;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RotacionPlayer();
        //UpDown();
    }

    private void RotacionPlayer()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(0, cameraAxisX * 4f, 0);        
    }

    //Para uso futuro. Movimiento del cañón arriba y abajo
    /*
    private void UpDown()
    {
        cameraAxisY += Input.GetAxis("Mouse Y");
        cannon.transform.rotation = Quaternion.Euler(cameraAxisY * 4f, cameraAxisX * 4, 0);
        
    }
    */


}
