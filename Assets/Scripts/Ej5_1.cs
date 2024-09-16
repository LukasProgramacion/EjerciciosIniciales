using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_1 : MonoBehaviour
{
    [SerializeField] int nivelPersonaje1, nivelPersonaje2;  
    // Start is called before the first frame update
    void Start()
    {
        if (nivelPersonaje1 == nivelPersonaje2)
        {
            Debug.Log("La batalla esta reñida ya que el nivel del personaje 1 es " + nivelPersonaje1 + " ,y el nivel del personaje 2 es " + nivelPersonaje2);
        }
        if (nivelPersonaje1 != nivelPersonaje2) 
        {
            if (nivelPersonaje1 > nivelPersonaje2)
            {
                Debug.Log("El nivel del personaje 1, " + nivelPersonaje1 + " es mayor que el del 2, que es " + nivelPersonaje2);
            }
            if (nivelPersonaje1 < nivelPersonaje2)
            {
                Debug.Log("El nivel del personaje 2, " + nivelPersonaje2 + " es mayor que el del 1, que es " + nivelPersonaje1);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
