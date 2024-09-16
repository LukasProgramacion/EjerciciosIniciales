using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_7 : MonoBehaviour
{
    [SerializeField] int velocidadJugador1, velocidadJugador2, velocidadJugador3;
    // Start is called before the first frame update
    void Start()
    {
        if (velocidadJugador1 > velocidadJugador2 && velocidadJugador1 > velocidadJugador3 )
        {
           //mas rapido el 1
            if (velocidadJugador2 > velocidadJugador3)
           {
                // 1, luego 2, luego 3
           }
           else
           {
                // 1, luego 3, luego 2
           }            
        }
        else if (velocidadJugador2 > velocidadJugador1 && velocidadJugador2 > velocidadJugador3)
        {
            //mas rapido el 2
            if (velocidadJugador1 > velocidadJugador3)
            {
                //2, luego 1, luego 3
            }
            else
            {
                // 2,  luego 3, luego 1
            }
        }
        else if (velocidadJugador3 >  velocidadJugador2 && velocidadJugador3 > velocidadJugador1)
        {
            // mas rapido el 3
            if (velocidadJugador2 > velocidadJugador1)
            {
                //3, luego 2, luego 1
            }
            else
            {
                //3, luego 1, luego 2
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
