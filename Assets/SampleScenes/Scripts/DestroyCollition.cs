using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollition : MonoBehaviour
{
    public GameObject ObjetoADestruir;
    public Collider ObjetoSensible;

    private void DetectaColision (Collider colision)
    {
        if (colision.gameObject.tag == "any" || colision.gameObject.tag == "asteroide")
        {
            Destroy(ObjetoADestruir);
        }
    }


    void Start()
    {
        
    }

    void Update()
    {
        DetectaColision(ObjetoSensible);
        
    }
}
