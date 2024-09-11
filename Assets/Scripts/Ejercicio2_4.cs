using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vidas = 100;
    // Start is called before the first frame update
    void Start()
    {
        vidas += 77;
        Debug.Log("Incrementar vidas en 77, = " + vidas);
        vidas -= 3;
        Debug.Log("Decrementar en 3, = " + vidas);
        vidas *= 4;
        Debug.Log("Cuadriplicar su valor, = " + vidas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
