using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public float speedTranslation; //Valor para obtener una distancia de translación


	void Update () {
        //Se obtiene un cambio de posición de nuestro First Person
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speedTranslation, //Movimiento con flechas A y D a Izquierda y Derecha resp.
                            0,                                                               //Sin movimiento en el eje Y
                            Input.GetAxis("Vertical") * Time.deltaTime * speedTranslation);  //Movimiento con flechas W y S Arriba y Abajo resp.
	}
}
