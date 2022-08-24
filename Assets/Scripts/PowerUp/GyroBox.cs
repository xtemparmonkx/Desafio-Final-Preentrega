using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroBox : MonoBehaviour
{

    [SerializeField] float SpeedGyro = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, SpeedGyro, 0);  
    }
}
