using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque_ENE : MonoBehaviour
{
    public Ataque ataque;
    public GameObject Rojo_Enemigo;
    public GameObject Azul_Enemigo;
    public GameObject Amarillo_Enemigo;
    bool debug;
    int eleccionJug;
    // Start is called before the first frame update
    void Start()
    {
        //ataque.Azul();
        //ataque.Amarillo();
        //ataque.Azul();
    }

    // Update is called once per frame
    void Update()
    {
        Pelea();
    }

    void Pelea()
    {
        if (ataque.Eleccion == 1) { 
            if (ataque.Eleccion_Rival==2)
            {
                if (!debug)
                {
                    Debug.Log("Perdiste");
                    debug = true;
                }
                Rojo_Enemigo.SetActive(true);
            }
            else if (ataque.Eleccion_Rival == 3)
            {
                if (!debug)
                {
                    Debug.Log("Ganaste");
                    debug = true;
                }
                Amarillo_Enemigo.SetActive(true);
            }
            else if (ataque.Eleccion_Rival == 1)
            {
                if (!debug)
                {
                    Debug.Log("Empate");
                    debug = true;
                }
                Azul_Enemigo.SetActive(true);
            }
        }
        else if (ataque.Eleccion == 2)
        {
            if (ataque.Eleccion_Rival == 2)
            {
                if (!debug)
                {
                    Debug.Log("Empate");
                    debug = true;
                }
                Rojo_Enemigo.SetActive(true);
            }
            else if (ataque.Eleccion_Rival == 3)
            {
                if (!debug)
                {
                    Debug.Log("Perdiste");
                    debug = true;
                }
                Amarillo_Enemigo.SetActive(true);
            }
            else if (ataque.Eleccion_Rival == 1)
            {
                if (!debug)
                {
                    Debug.Log("Ganaste");
                    debug = true;
                }
                Azul_Enemigo.SetActive(true);
            }
        }
        else if (ataque.Eleccion == 3)
        {
            if (ataque.Eleccion_Rival == 2)
            {
                if (!debug)
                {
                    Debug.Log("Ganaste");
                    debug = true;
                }
                Rojo_Enemigo.SetActive(true);
            }
            else if (ataque.Eleccion_Rival == 3)
            {
                if (!debug)
                {
                    Debug.Log("Empate");
                    debug = true;
                }
                Amarillo_Enemigo.SetActive(true);
            }
            else if (ataque.Eleccion_Rival == 1)
            {
                if (!debug)
                {
                    Debug.Log("Perdiste");
                    debug = true;
                }
                Azul_Enemigo.SetActive(true);
            }
        }
        else
        {
            return;
        }
    }
}
