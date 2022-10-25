using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{
    public int Eleccion;
    public int Eleccion_Rival;
    // Start is called before the first frame update
    void Start()
    {
        Eleccion = 0;
        Eleccion_Rival = Random.Range(1, 4);
        //Debug.Log(Eleccion_Rival.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Azul()
    {
        //Debug.Log("Azul");
        Eleccion = 1;
    }

    public void Rojo()
    {
        //Debug.Log("Rojo");
        Eleccion = 2;
    }

    public void Amarillo()
    {
        //Debug.Log("Amarillo");
        Eleccion = 3;
    }
}
