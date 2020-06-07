using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidesSpawn : MonoBehaviour
{
    public Collider AsteroidePadre;
    // Start is called before the first frame update
    void Start()
    {
        AsteroidePadre = GetComponent<Collider>();

        GameObject prefab = Resources.Load("asteroide1") as GameObject;
        for (int i = 0; i <= 1000; i++)
        {
            GameObject asteroide = Instantiate(prefab);
            //asteroide.transform.position = new Vector3(Random.Range(-1000.0f, 1000.0f), Random.Range(-500.0f, 500.0f), Random.Range(300.0f, 1900.0f));
            asteroide.transform.position = new Vector3(Random.Range(-1000.0f, 1000.0f), Random.Range(-500.0f, 500.0f), Random.Range(300.0f, 3000.0f));

            GameObject asteroide2 = Instantiate(prefab);
            //asteroide2.transform.position = new Vector3(Random.Range(-1000.0f, 1000.0f), Random.Range(-500.0f, 500.0f), Random.Range(2100.0f, 3000.0f));
            asteroide2.transform.position = new Vector3(Random.Range(-1000.0f, 1000.0f), Random.Range(-500.0f, 500.0f), Random.Range(300.0f, 3000.0f));
        }

        GameObject prefab2 = Resources.Load("asteroide2") as GameObject;
        for (int i = 0; i <= 750; i++)
        {
            GameObject asteroide3 = Instantiate(prefab2);
            //asteroide3.transform.position = new Vector3(Random.Range(-1000.0f, 1000.0f), Random.Range(-800.0f, 800.0f), Random.Range(300.0f, 1900.0f));
            asteroide3.transform.position = new Vector3(Random.Range(-1000.0f, 1000.0f), Random.Range(-800.0f, 800.0f), Random.Range(300.0f, 3000.0f));

            GameObject asteroide4 = Instantiate(prefab2);
            //asteroide4.transform.position = new Vector3(Random.Range(-1000.0f, 1000.0f), Random.Range(-800.0f, 800.0f), Random.Range(2100.0f, 3000.0f));
            asteroide4.transform.position = new Vector3(Random.Range(-1000.0f, 1000.0f), Random.Range(-800.0f, 800.0f), Random.Range(300.0f, 3000.0f));
        }

        GameObject prefab3 = Resources.Load("asteroide3") as GameObject;
        for (int i = 0; i <= 2000; i++)
        {
            GameObject asteroide5 = Instantiate(prefab2);
            //asteroide5.transform.position = new Vector3(Random.Range(-300.0f, 300.0f), Random.Range(-300.0f, 300.0f), Random.Range(300.0f, 1900.0f));
            asteroide5.transform.position = new Vector3(Random.Range(-300.0f, 300.0f), Random.Range(-300.0f, 300.0f), Random.Range(300.0f, 2500.0f));
        }

        for (int i = 0; i <= 1000; i++)
        {
            GameObject asteroide6 = Instantiate(prefab2);
            //asteroide6.transform.position = new Vector3(Random.Range(-300.0f, 300.0f), Random.Range(-300.0f, 300.0f), Random.Range(2100.0f, 2500.0f));
            asteroide6.transform.position = new Vector3(Random.Range(-300.0f, 300.0f), Random.Range(-300.0f, 300.0f), Random.Range(300.0f, 2500.0f));
        }     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision )
    {

        if ((collision.gameObject.tag == "asteroide1") || (collision.gameObject.tag == "asteroide2") || (collision.gameObject.tag == "asteroide3"))
        {
            Physics.IgnoreCollision(collision.collider, AsteroidePadre);
        }

    }
}
