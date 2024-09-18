using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_7 : MonoBehaviour
{
    [SerializeField] int velocidadJugador1 = 50, velocidadJugador2 = 25, velocidadJugador3 = 75;
    // Start is called before the first frame update
    void Start()
    {
        if (velocidadJugador1 > velocidadJugador2 && velocidadJugador1 > velocidadJugador3 )
        {
            Debug.Log("La velocidad del jugador 1, " + velocidadJugador1 + " es la más rapida");
            if (velocidadJugador2 > velocidadJugador3)
           {
                Debug.Log("La velocidad del jugador 1, " + velocidadJugador1 + " es la más rapida, después la del 2: " + velocidadJugador2 + " y despues la del 3:" + velocidadJugador3);
           }
           else
           {
                Debug.Log("La velocidad del jugador 1, " + velocidadJugador1 + " es la más rapida, después la del 3: " + velocidadJugador3 + " y despues la del 2:" + velocidadJugador2);
            }            
        }
        else if (velocidadJugador2 > velocidadJugador1 && velocidadJugador2 > velocidadJugador3)
        {
            Debug.Log("La velocidad del jugador 2, " + velocidadJugador2 + " es la más rapida");
            if (velocidadJugador1 > velocidadJugador3)
            {
                Debug.Log("La velocidad del jugador 2, " + velocidadJugador2 + " es la más rapida, después la del 1: " + velocidadJugador1 + " y despues la del 3:" + velocidadJugador3);
            }
            else
            {
                Debug.Log("La velocidad del jugador 2, " + velocidadJugador2 + " es la más rapida, después la del 3: " + velocidadJugador3 + " y despues la del 1:" + velocidadJugador1);
            }
        }
        else if (velocidadJugador3 >  velocidadJugador2 && velocidadJugador3 > velocidadJugador1)
        {
            Debug.Log("La velocidad del jugador 3, " + velocidadJugador3 + " es la más rapida");
            if (velocidadJugador2 > velocidadJugador1)
            {
                Debug.Log("La velocidad del jugador 3, " + velocidadJugador3 + " es la más rapida, después la del 2: " + velocidadJugador2 + " y despues la del 1:" + velocidadJugador1);
            }
            else
            {
                Debug.Log("La velocidad del jugador 3, " + velocidadJugador3 + " es la más rapida, después la del 1: " + velocidadJugador1 + " y despues la del 2:" + velocidadJugador2);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
