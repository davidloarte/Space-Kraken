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
        //descarto poner el eje z porque no se puede mover el mouse en el
        distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2, Vector3.up) * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * 2, Vector3.forward) * distancia;
        //distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * 2, Vector3.forward) * distancia;
        //distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse Z") * 2, Vector3.right) * distancia;

        transform.position = jugador.transform.position + distancia;
        transform.LookAt(jugador.transform.position);

        // Usamos referencia para que nuestros controles no varien
        //Vector3 copiaRotacion = new Vector3(0, transform.eulerAngles.y, 0);
        Vector3 copiaRotacion = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
        referencia.transform.eulerAngles = copiaRotacion;

    }
}
