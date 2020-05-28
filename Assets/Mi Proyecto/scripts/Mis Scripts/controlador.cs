using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador : MonoBehaviour
{
    public float tiempo;

    public static float tiempo2;
    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}
