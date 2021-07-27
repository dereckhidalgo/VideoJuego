using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject Lazer;

    public float tiempo_disparo = 0.5f;
    float siguiente_fuego = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > siguiente_fuego)
        {
            siguiente_fuego = Time.time + tiempo_disparo;
            dispara();
        }
    }
    void dispara()
    {
        Instantiate(Lazer, transform.position, Quaternion.identity);
    }
}
