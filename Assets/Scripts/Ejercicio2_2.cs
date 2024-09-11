using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 10;
    float exp = 100f, resultadoSuma, resultadoResta;
    char carac;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Vida " + vidas);
        Debug.Log("Exp " + exp);
        resultadoSuma = vidas + exp;
        resultadoResta = exp - vidas;
        Debug.Log("Resultado suma " + resultadoSuma);
        Debug.Log("Resultado resta " + resultadoResta);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
