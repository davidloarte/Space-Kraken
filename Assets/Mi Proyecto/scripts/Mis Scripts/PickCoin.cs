using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickCoin : MonoBehaviour
{
    private int contador = 0;
    public AudioClip sonidoMoneda;
    public float volumen;
    private Transform posicionSonido;

    public GameObject halo;
    public Collider bandera;
    public Collider nave;
    // Start is called before the first frame update
    void Start()
    {
        posicionSonido = transform;
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "bandera")
        {
            Physics.IgnoreCollision(nave.GetComponent<Collider>(), bandera.GetComponent<Collider>());
            Destroy(collision.gameObject);
            contador++;
            AudioSource.PlayClipAtPoint(sonidoMoneda, posicionSonido.position, volumen * 1);
        }

        if (collision.gameObject.tag == "base" && contador > 0)
        {
            //Debug.Log("has ganado");
            SceneManager.LoadScene("Ganar");
        }

        if (collision.gameObject.tag == "potenciador")
        {
            Physics.IgnoreCollision(nave.GetComponent<Collider>(), bandera.GetComponent<Collider>());
            Destroy(collision.gameObject);
           
            Debug.Log("potenciador");
            halo.SetActive(true);
            //halo.GetType().GetProperty("Size").SetValue(halo, 2f + Mathf.Sin(Time.time), null);

            AudioSource.PlayClipAtPoint(sonidoMoneda, posicionSonido.position, volumen * 1);
        }

    }
}