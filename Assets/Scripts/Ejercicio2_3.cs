using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 10;
    float exp = 100f, resultadoMultiplicacion, resultadoCociente, resultadoResto, resultadoDobleVidas, resultadoTripleExp;
    // Start is called before the first frame update
    void Start()
    {
        resultadoMultiplicacion = vidas * exp;
        resultadoCociente = vidas / exp;
        resultadoResto = vidas % exp;
        resultadoDobleVidas = vidas * 2;
        resultadoTripleExp = exp * 3;
        Debug.Log("Resultado multiplicacion " + resultadoMultiplicacion);
        Debug.Log("Resultado cociente " + resultadoCociente);
        Debug.Log("Resultado resto " + resultadoResto);
        Debug.Log("Doble de la vida " + resultadoDobleVidas);
        Debug.Log("Triple de la exp " + resultadoTripleExp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
