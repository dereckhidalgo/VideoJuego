using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneraGlobos : MonoBehaviour
{
    public GameObject globoVerde;
    public GameObject globoNaranja;
    public GameObject globoAzul;
    public GameObject globoRosado;
    public GameObject globoAmarillo;

    public bool stopSpawning = false;
    public float spawnTime = 0.5f;
    public float spawnDelay = 2.9f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("generaGlobo", spawnTime, spawnDelay);
    }

    public void generaGlobo()
    {
        int aleatorio = Random.Range(1, 6);

        if(aleatorio == 1)
        {
            Instantiate(globoVerde, transform.position, transform.rotation);
        }else if(aleatorio == 2)
        {
            Instantiate(globoNaranja, transform.position, transform.rotation);
        }else if(aleatorio == 3)
        {
            Instantiate(globoAzul, transform.position, transform.rotation);
        }else if(aleatorio == 4)
        {
            Instantiate(globoRosado, transform.position, transform.rotation);
        }else if(aleatorio == 5)
        {
            Instantiate(globoAmarillo, transform.position, transform.rotation);
        }
        
        if (stopSpawning)
        {
            CancelInvoke("generaGlobo");
        }
    }
}
