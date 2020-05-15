using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CameraControlV3 : MonoBehaviour
{

    public GameObject jugador;
    public GameObject Camara2;

    public bool cambiado = false;

    public bool seguirPosicion;
    public float acercartoPosicion = 0.05f;
    public bool seguirRotacion;
    public float acercarRotacion = 0.05f;

    public bool invertirEjes = false;

    private int contador = 0;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.V))
        {
            if (contador % 2 == 0)
                cambiado = true;
            else
                cambiado = false;
            contador++;
        }

        if (cambiado == false)
        {
            acercartoPosicion = 0.05f;

            acercarRotacion = 0.05f;

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

        if (cambiado == true)
        {
            acercartoPosicion = 1.0f;

            acercarRotacion = 1.0f;

            if (!invertirEjes)
            {
                if (seguirPosicion)
                {
                    transform.position = Vector3.Lerp(transform.position, Camara2.transform.position, acercartoPosicion);
                }

                if (seguirRotacion)
                {
                    transform.rotation = Quaternion.Lerp(transform.rotation, Camara2.transform.rotation, acercarRotacion);
                }
            }
            else
            {
                if (seguirPosicion)
                {
                    transform.position = Vector3.Lerp(transform.position, Camara2.transform.position, acercartoPosicion);
                }

                if (seguirRotacion)
                {
                    transform.rotation = Quaternion.Lerp(transform.rotation, Camara2.transform.rotation, acercarRotacion);
                }

            }
        }

    }
   
}
