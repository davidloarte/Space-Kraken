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
    public float acercartoPosicion = 0.15f;
    public bool seguirRotacion;
    public float acercarRotacion = 0.15f;

    public bool invertirEjes = false;

    private int contador = 0;
    private float tiempoEspera = 0.5f;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        tiempoEspera = tiempoEspera - Time.deltaTime;
        if (Input.GetKey(KeyCode.V) && tiempoEspera <= 0)
        {
            if (contador % 2 == 0)
                cambiado = true;
            else
                cambiado = false;

            contador++;
            tiempoEspera = 0.5f;
        }

        if (cambiado == false)
        {
            acercartoPosicion = 0.15f;

            acercarRotacion = 0.15f;

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
