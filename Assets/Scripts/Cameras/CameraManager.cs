using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject[] cameras;
    public bool CamaraActiva = true;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {

        if (CamaraActiva == true && Input.GetKeyDown(KeyCode.C))
        {
            CamaraActiva = false;
            cameras[1].SetActive(true);
        }
        else if (CamaraActiva == false && Input.GetKeyDown(KeyCode.C))
        {
            CamaraActiva = true;
            cameras[1].SetActive(false);
        }

    }

    

}
