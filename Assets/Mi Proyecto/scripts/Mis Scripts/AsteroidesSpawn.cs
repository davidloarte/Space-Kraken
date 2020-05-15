using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidesSpawn : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject prefab = Resources.Load("asteroide1") as GameObject;
        for (int i = 0; i<= 2000; i++)
        {
            GameObject asteroide = Instantiate(prefab);
            asteroide.transform.position = new Vector3(Random.Range(-500.0f, 500.0f), Random.Range(-1000.0f, 1000.0f), Random.Range(200.0f, 1850.0f));
        }

        GameObject prefab2 = Resources.Load("asteroide2") as GameObject;
        for (int i = 0; i <= 2000; i++)
        {
            GameObject asteroide = Instantiate(prefab2);
            asteroide.transform.position = new Vector3(Random.Range(-500.0f, 500.0f), Random.Range(-500.0f, 500.0f), Random.Range(200.0f, 3000.0f));
        }

        GameObject prefab3 = Resources.Load("asteroide3") as GameObject;
        for (int i = 0; i <= 2000; i++)
        {
            GameObject asteroide = Instantiate(prefab3);
            asteroide.transform.position = new Vector3(Random.Range(-500.0f, 500.0f), Random.Range(-500.0f, 500.0f), Random.Range(200.0f, 3000.0f));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
            GameObject asteroide = Instantiate(prefab);
            asteroide.transform.position = new Vector3(Random.Range(-1000.0f, -55.0f), Random.Range(-1000.0f, -55.0f), Random.Range(200.0f, 1945.0f));

            GameObject asteroide2 = Instantiate(prefab);
            asteroide2.transform.position = new Vector3(Random.Range(55.0f, 1000.0f), Random.Range(55.0f, 1000.0f), Random.Range(2055.0f, 3000.0f));
     */

     /*
        GameObject asteroide = Instantiate(prefab);
        asteroide.transform.position = new Vector3(Random.Range(-500.0f, 500.0f), Random.Range(-1000.0f, 1000.0f), Random.Range(200.0f, 1850.0f));
     */

}
