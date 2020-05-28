using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chekeador : MonoBehaviour
{
    double score = 0;
    string name = "";

    public float cuentaAtras = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        //Hace invisible el cursor mientras juegas
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("SpaceshipFighter_Spear"))
        {
            score = CuentaAtras.horaActual;
            name = controlador.nombre2;
            if (PlayerPrefs.GetFloat("Highscore") > score)
            {
                PlayerPrefs.SetFloat("Highscore", ToSingle(score));
                PlayerPrefs.SetString("Name", name);
                Debug.Log("nombre: " + name + " score: " + score);
            }
            cuentaAtras -= Time.deltaTime;

        }
        if (cuentaAtras <= 0 )
        {
            Cursor.visible = true;
            SceneManager.LoadScene("Failed");
        }
    }
    // funcion para convertir de double a float
    public static float ToSingle(double value)
    {
        return (float)value;
    }
}
