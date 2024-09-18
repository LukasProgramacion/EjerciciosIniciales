using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_9 : MonoBehaviour
{
    [SerializeField] int tipo;
    // Start is called before the first frame update
    void Start()
    {
        if (tipo >= 1 && tipo <= 6)
        {
            if (tipo == 1)
            {
                Debug.Log("El daño del enemigo tipo 1 es: 350 y su vida es: 650");
            }
            if (tipo == 2)
            {
                Debug.Log("El daño del enemigo tipo 2 es: 300 y su vida es: 550");
            }
            if (tipo == 3)
            {
                Debug.Log("El daño del enemigo tipo 3 es: 300 y su vida es: 500");
            }
            if (tipo == 4)
            {
                Debug.Log("El daño del enemigo tipo 4 es: 310 y su vida es: 460");
            }
            if (tipo == 5)
            {
                Debug.Log("El daño del enemigo tipo 5 es: 280 y su vida es: 490");
            }
            if (tipo == 6)
            {
                Debug.Log("El daño del enemigo tipo 6 es: 360 y su vida es: 520");
            }

        }
        
        else
        {
            Debug.Log("Introduce un numero entre 1 y 6");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
