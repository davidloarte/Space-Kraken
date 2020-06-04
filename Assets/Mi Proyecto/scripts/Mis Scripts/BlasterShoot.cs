using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterShoot : MonoBehaviour
{
    public Rigidbody disparoPrefab;
    public Transform lanzador1;
    public Transform lanzador2;
    public Transform lanzador3;
    public Transform lanzador4;
    public float velocidadDisparo;
    public float tiempoDisparo;
    private float inicioDisparar;

    public AudioClip sonidoDisparo;
    public float volumen;
    private Transform posicionSonido;

    public bool paraAndroid = false;
    public Camera camara;
    void Start()
    {
        posicionSonido = transform;
    }

    void Update()
    {
        // Fire 1 es el boton que tiene asignado unity por defecto al boton izquierdo del rato
        if (Input.GetButton("Fire1") && (Time.time > inicioDisparar && !paraAndroid))
        {
            dispara();
        }

        if (paraAndroid)
        {
            int k = 0;
            Touch t = Input.GetTouch(k);
            Vector2 tocado = devuelveTocado(t.position);
            if (t.position.y > Screen.height / 2 && Time.time > inicioDisparar)
                dispara();
            
        }
    }

    Vector2 devuelveTocado(Vector2 lugarTocado)
    {
        return camara.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(lugarTocado.x, lugarTocado.y, transform.position.z));
    }
    
    void dispara()
    {
        // esto provoca que no se pueda disparar de seguido si no que produce un retardo en el tiempo de disparo
        inicioDisparar = Time.time + tiempoDisparo;
        Rigidbody disparoPrefabInstanciado1;
        Rigidbody disparoPrefabInstanciado2;
        Rigidbody disparoPrefabInstanciado3;
        Rigidbody disparoPrefabInstanciado4;

        // aqui instanciamos el disparo, el que queremos como disparo, su posicion, y su lugar y lo instanciamos como Rigidbody para poder hacer colisiones con el
        disparoPrefabInstanciado1 = Instantiate(disparoPrefab, lanzador1.position, Quaternion.identity) as Rigidbody;
        // ahora le añadimos el movimiento
        disparoPrefabInstanciado1.AddForce(lanzador1.forward * 100 * velocidadDisparo);

        //Hacemos lo mismo para los otros puntos de disparo
        disparoPrefabInstanciado2 = Instantiate(disparoPrefab, lanzador2.position, Quaternion.identity) as Rigidbody;
        disparoPrefabInstanciado2.AddForce(lanzador2.forward * 100 * velocidadDisparo);

        disparoPrefabInstanciado3 = Instantiate(disparoPrefab, lanzador3.position, Quaternion.identity) as Rigidbody;
        disparoPrefabInstanciado3.AddForce(lanzador3.forward * 100 * velocidadDisparo);

        disparoPrefabInstanciado4 = Instantiate(disparoPrefab, lanzador4.position, Quaternion.identity) as Rigidbody;
        disparoPrefabInstanciado4.AddForce(lanzador4.forward * 100 * velocidadDisparo);

        //Destroy(disparoPrefabInstanciado1, 10);
        //Destroy(disparoPrefabInstanciado2, 10);

        // Hacemos que suene el disparo
        AudioSource.PlayClipAtPoint(sonidoDisparo, posicionSonido.position, volumen * 100);

        //Destroy(disparoPrefab, 5);
        //pruebap
    }
}
