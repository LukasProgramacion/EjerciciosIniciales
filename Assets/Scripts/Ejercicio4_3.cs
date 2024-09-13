using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float cantidadDolaresConvertidos = ConvertirEurosADolares(110, "Dolares");
        Debug.Log("110 euros pasados a dolares son, " + cantidadDolaresConvertidos + " dolares");
        float cantidadEurosConvertidos = ConvertirDolaresAEuros(95, "Euros");
        Debug.Log("95 dolares pasados a euros son, " + cantidadEurosConvertidos + " euros");
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    float ConvertirEurosADolares (float cantidadEuros, string moneda)
    {
        float dolaresConvertidos = cantidadEuros * 1.1097f;
        return dolaresConvertidos;
    }

    float ConvertirDolaresAEuros (float cantidadDolares, string moneda)
    {
        float eurosConvertidos = cantidadDolares * 0.9010f;
        return eurosConvertidos;
    }
}
