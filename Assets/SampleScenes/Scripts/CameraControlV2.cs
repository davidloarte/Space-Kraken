using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlV2 : MonoBehaviour
{
    public GameObject jugador;
    public GameObject referencia;
    private Vector3 distancia;

    void Start()
    {
        // esto hace que la disctancia con el jugador sea contante
        distancia = transform.position - jugador.transform.position;        
    }

    // usamos un late update para indicar que se va a actualizar un frame mas tarde
    void LateUpdate()
    {
        distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2, Vector3.up) * distancia;

        transform.position = jugador.transform.position + distancia;
        transform.LookAt(jugador.transform.position);

        // Usamos referencia para que nuestros controles no varien
        Vector3 copiaRotacion = new Vector3(0, transform.eulerAngles.y, 0);
        referencia.transform.eulerAngles = copiaRotacion;

    }
}
