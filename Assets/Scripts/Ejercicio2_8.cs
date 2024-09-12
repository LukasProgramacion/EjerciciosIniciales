using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float vidaInicial = 120f, vidaActual;
    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaInicial - (3f * vidaInicial / 100f);
        Debug.Log("Ha pasado el primer turno, se te ha restado un 3% a tu cantidad de puntos iniciales, ahora tienes " 
            + vidaActual + " de puntos");

        vidaActual = vidaInicial - (6f * vidaInicial / 100f);
        Debug.Log("Ha pasado el segundo turno, se te ha restado un 6% a tu cantidad de puntos iniciales, ahora tienes "
            + vidaActual + " de puntos");

        vidaActual = vidaInicial - (9f * vidaInicial / 100f);
        Debug.Log("Ha pasado el tercer turno, se te ha restado un 9% a tu cantidad de puntos iniciales, ahora tienes "
            + vidaActual + " de puntos");

        vidaActual = vidaInicial - (12f * vidaInicial / 100f);
        Debug.Log("Ha pasado el cuarto turno, se te ha restado un 12% a tu cantidad de puntos iniciales, ahora tienes "
            + vidaActual + " de puntos");

        vidaActual = vidaInicial - (15f * vidaInicial / 100f);
        Debug.Log("Ha pasado el quinto turno, se te ha restado un 15% a tu cantidad de puntos iniciales, ahora tienes "
            + vidaActual + " de puntos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
