using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlV3 : MonoBehaviour
{

    public GameObject jugador;

    public bool seguirPosicion;
    public float acercartoPosicion = 0.05f;
    public bool seguirRotacion;
    public float acercarRotacion = 0.05f;

    public bool invertirEjes = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (!invertirEjes)
        {
            if (seguirPosicion)
            {
                transform.position = Vector3.Lerp(transform.position, jugador.transform.position, acercartoPosicion);
            }

            if (seguirRotacion)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, jugador.transform.rotation, acercarRotacion);
            }
        }
        else
        {
            if (seguirPosicion)
            {
                transform.position = Vector3.Lerp(transform.position, jugador.transform.position, acercartoPosicion);
            }

            if (seguirRotacion)
            {
                transform.rotation = Quaternion.Lerp(transform.rotation, jugador.transform.rotation, acercarRotacion);
            }
        }
        
    }

}
