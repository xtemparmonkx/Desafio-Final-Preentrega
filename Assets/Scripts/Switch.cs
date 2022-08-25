using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    enum Muerte { MuertePlayer }
    [SerializeField] Muerte muerte;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            // Usamos switch para determinar que movimiento corresponde segun el tipo de enemigo seleccionado.
            switch (muerte)
            {
                case Muerte.MuertePlayer:
                    if (GameObject.FindWithTag("Player") == null)
                        Debug.Log("GAME OVER");
                    break;

                                
            }
        }
    }
}
