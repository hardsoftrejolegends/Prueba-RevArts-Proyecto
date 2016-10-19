using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public float speedRotation = 50f;
    float angulo = 0f;

	void Update () {
        angulo += Input.GetAxis("Mouse Y") * Time.deltaTime * speedRotation; //Obtiene un angulo calculando el movimiento vertical del mouse
        angulo = Mathf.Clamp(angulo,-60, 60);
        transform.localEulerAngles = new Vector3(-angulo, 
                                        0,//Input.GetAxis("Mouse X") * Time.deltaTime * speedRotation + transform.localEulerAngles.y,
                                        0);


	}
}
