using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador : MonoBehaviour
{
    public float tiempo;
    public static float tiempo2;

    public string nombre;
    public static string nombre2;
    // Start is called before the first frame update
    void Start()
    {
        nombre = MenuPrincipal.nombre;
        nombre2 = nombre;
    }

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        tiempo = MenuPrincipal.tiempo;
        tiempo2 = tiempo;
        Debug.Log(tiempo.ToString());

        nombre = MenuPrincipal.nombre;
        nombre2 = nombre;
        Debug.Log("el nombre es : " + nombre);

    }
}
