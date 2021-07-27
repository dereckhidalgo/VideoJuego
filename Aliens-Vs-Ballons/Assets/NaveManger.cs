using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveManger : MonoBehaviour
{
    public float posicionX = 6f;
    public float posicionY = 1f;
    public float velocidad = 6f;

    // Start is called before the first frame update
    void Start()
    {
  
        GetComponent<Transform>().position = new Vector3(6.5f, posicionY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        posicionY = Input.GetAxis("Vertical");
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    movementSystem(posicionY);
        //}

        movementSystem(posicionY);
    }

    public void movementSystem(float y)
    {
        // GetComponent<Transform>().Translate(y * velocidad * Time.deltaTime, posicionX, 0);
        GetComponent<Transform>().Translate(y * velocidad * Time.deltaTime , 0f, 0f);
    }
}
