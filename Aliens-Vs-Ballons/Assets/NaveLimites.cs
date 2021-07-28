using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveLimites : MonoBehaviour
{
    

    private float ancho_nave;
    private Vector2 tamPantalla;

    public GameObject efectoExplosion;
    //SONIDO DE EXPLOSION
    
    private bool explotado;
    // Start is called before the first frame update
    void Start()
    {
        
        this.explotado = false;
        tamPantalla = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        ancho_nave = GetComponent<SpriteRenderer>().bounds.size.y / 2;
    
    }
    void LateUpdate()
    {
        //OBTENER POSICION DEL OBJETO
        Vector3 posicion = transform.position;
        
        //VERIFICAR SI EL TAMANO DE LA PANTALLA + ANCHO DE LA NAVE ES MAYOR A LA POSICION EN EJE (Y)(CHOQUE ABAJO)
        //SE MULTIPLICA POR -1 PARA OBTENER LA COORDENADA NEGATIVA A POSITIVA
        //PARA DETECTAR EL CHOQUE SUPERIOR SE CALCULA EN POSITIVO
        //La medida 0.1f ES PARA COMPENSAR LA UNIDAD FALTANTE YA QUE LA CONDICION SE CUMPLICA UN POCO ANTES DEL TOPE
        if((tamPantalla.y +0.1f) * -1 + ancho_nave > posicion.y || (tamPantalla.y + 0.1f) - ancho_nave < posicion.y){
            if(this.explotado == false){
                this.explotado = true;
                explotaNave();
            }
            //aqui debajo iria gameOver()
        }

    }

    void explotaNave(){
        GameObject efecto = Instantiate(efectoExplosion, transform.position, Quaternion.identity);
        Destroy(this.gameObject); //DELIMINAR EL OBJETO DE LA NAVE
        Destroy(efecto, 2);

    }

}
