using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollition : MonoBehaviour
{
    public AudioClip sonidoExplosion;
    public float volumen;
    private Transform posicionSonido;

    public GameObject efectoExplosion;
    private bool haExplotado = false;
    GameObject efectoExplosion2;

    void Start()
    {
        posicionSonido = transform;
    }
    // Funcion que detecta las colisiones en los objetos
    private void OnCollisionEnter(Collision collision)
    {
        // Destruye el disparo
        Destroy(gameObject);

        // Dos maneras diferentes de decir para el mismo tag
        if ((collision.gameObject.tag.Equals ("asteroide1") || collision.gameObject.tag == "asteroide") && haExplotado == false)
        {
            //Si detecta la colision con un objeto de ese tio elimina el objeto y el disparo
            Destroy(collision.gameObject);
            Destroy(gameObject);

            //Instanciamos el efecto con nuestro efecto, donde y su rotacion            
            Explotar();
            haExplotado = true;

            // Hacemos que suene la explosion
            AudioSource.PlayClipAtPoint(sonidoExplosion, posicionSonido.position, volumen * 10000000);
        }

        if (collision.gameObject.tag.Equals("any"))
        {

        }

    }

    public void Explotar()
    {
        //Instantiate(efectoExplosion, transform.position, transform.rotation);
        efectoExplosion2 = Instantiate(efectoExplosion, transform.position, transform.rotation);
        efectoExplosion2.SetActive(true);
        Destroy(efectoExplosion2, 3);
    }
}
 