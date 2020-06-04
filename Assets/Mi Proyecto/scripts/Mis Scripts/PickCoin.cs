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

    double score = 0;
    string name = "";

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
            score = 600.0f - CuentaAtras.horaActual;
            name = controlador.nombre2;
            //Debug.Log("he llegado aqui y he encontrado nombre: " + name + " score: " + score);
            if (PlayerPrefs.GetFloat("Highscore") > score || PlayerPrefs.GetFloat("Highscore") == 0)
            {
                Debug.Log("ahora he encontrdo que no hay nada mejor en hihgscore");
                PlayerPrefs.SetFloat("Highscore", ToSingle(score));
                PlayerPrefs.SetString("Name", name);
                //Debug.Log("encontrado nombre: " + name + " score: " + score);
            }
            SceneManager.LoadScene("Ganar");
        }

        if (collision.gameObject.tag == "potenciador")
        {
            Physics.IgnoreCollision(nave.GetComponent<Collider>(), bandera.GetComponent<Collider>());
            Destroy(collision.gameObject);

            halo.SetActive(true);
            AudioSource.PlayClipAtPoint(sonidoMoneda, posicionSonido.position, volumen * 1);
        }

    }

    // funcion para convertir de double a float
    public static float ToSingle(double value)
    {
        return (float)value;
    }
}