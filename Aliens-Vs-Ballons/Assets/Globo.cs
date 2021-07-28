using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globo : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite nuevoSprite;


    //SUBIR
    public float posicionX = -7.13f;
    public float posicionY = -3.99f;
    public float velocidad = 1f;

    Animator anim;
    public Sprite[] frames;
    // Start is called before the first frame update
    void Awake()
    {
    }
    void Start()
    {
        
        anim = this.GetComponent<Animator>();
        anim.enabled = false;
        
        GetComponent<Transform>().position = new Vector3(posicionX, posicionY, 0);
    }
    // Update is called once per frame
    void Update()
    {
        subeGlobo();
    }

    void subeGlobo()
    {
        GetComponent<Transform>().Translate(0f, 2.0f * velocidad * Time.deltaTime, 0f);
    }
    void cambiaSprite()
    {
        spriteRenderer.sprite = nuevoSprite;
    }

    private IEnumerator OnTriggerEnter2D(Collider2D col)
    {
        anim.enabled = true;
        //ESPERAR A QUE LA ANIMACION TERMINA PARA DESTRUIR EL GLOBO
        yield return new WaitForSeconds(anim.GetCurrentAnimatorStateInfo(0).length + anim.GetCurrentAnimatorStateInfo(0).normalizedTime);

        Destroy(col.gameObject);
        this.gameObject.SetActive(false);
    }

}
