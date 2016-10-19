using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collector : MonoBehaviour {
    public int puntuation; //Discos cogidos
    public Text puntuationText; //UI text de discos cogidos
    public GameObject particleDisk; //Particulas al tomar un disk

    void Start()
    {
        puntuationText.text = "0/6"; //Inicia con 0 discos cogidos
    }

    //Detecta colisiones que Tengan habilitado Trigger
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Disk") //Busca objetos con el TAG de DISK
        {
            puntuation += 1; //Incrementa la puntuación
            puntuationText.text = puntuation + "/6"; //Despliega la puntuación en pantalla
            Destroy( Instantiate(particleDisk, other.gameObject.transform.localPosition, Quaternion.identity), 4f); //Elimina las particulas a los 4 segundos, también crea las partículas en la posición del DISK y con una rotación nula
            Destroy(other.gameObject);  //Elimina el DISK 
        }
    }
}
