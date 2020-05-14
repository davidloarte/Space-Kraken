using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CameraControlV3 : MonoBehaviour
{

    public GameObject jugador;

    public bool seguirPosicion;
    public float acercartoPosicion = 0.05f;
    public bool seguirRotacion;
    public float acercarRotacion = 0.05f;

    public bool invertirEjes = false;

    public float cuentaAtras = 3f;
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

            if (!jugador)
            {
                Debug.Log("llego");
                cuentaAtras -= Time.deltaTime;

                if (cuentaAtras < 0)
                {
                    SceneManager.LoadScene("Failed");
                }

                //StartCoroutine(Cuenta());
            }
        }
    }
    //IEnumerator Cuenta()
    //{
    //    yield return new WaitForSeconds(cuentaAtras);
    //    SceneManager.LoadScene("Failed");
    //}
    

}
