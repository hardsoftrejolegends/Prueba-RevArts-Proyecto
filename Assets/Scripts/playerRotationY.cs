using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRotationY : MonoBehaviour {

    public float speedRotation = 50f; //Velocidad de rotación

    void Update()
    {
        //Cálculo de la rotación sobre el First Player en el eje Y 
        transform.localEulerAngles = new Vector3(0,
                                        Input.GetAxis("Mouse X") * Time.deltaTime * speedRotation + transform.localEulerAngles.y, //Se obtiene el movimiento Horizontal del Mouse 
                                        0);
    }
}
