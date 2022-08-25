using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giroArma : MonoBehaviour
{
    public float cameraAxisX = 0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RotacionPlayer();
    }

    private void RotacionPlayer()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        transform.position = new Vector3(cameraAxisX * 2f, 0, -5f);
    }

}
