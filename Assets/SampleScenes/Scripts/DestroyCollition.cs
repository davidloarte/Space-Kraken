using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollition : MonoBehaviour
{

    public AudioClip sonidoExplosion;
    public float volumen;
    private Transform posicionSonido;

    void Start()
    {
        posicionSonido = transform;
    }
    void Update()
    {
     
        
    }

    // Funcion que detecta las colisiones en los objetos
    private void OnCollisionEnter(Collision collision)
    {
        // Destruye el disparo
        Destroy(gameObject);

        // Dos maneras diferentes de decir para el mismo tag
        if (collision.gameObject.tag.Equals ("asteroide1") || collision.gameObject.tag == "asteroide")
        {
            //Si detecta la colision con un objeto de ese tio elimina el objeto y el disparo
            Destroy(collision.gameObject);
            Destroy(gameObject);

            // Hacemos que suene la explosion
            AudioSource.PlayClipAtPoint(sonidoExplosion, posicionSonido.position, volumen * 10000000);
        }

    }
}
