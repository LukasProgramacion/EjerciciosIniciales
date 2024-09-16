using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    [SerializeField] string moneda;

    // Start is called before the first frame update
    void Start()
    {
        if (moneda == "EURO")
        {
            float resultado = Convertir(8);
            Debug.Log("Teniendo, 8 euros, ahora tienes, " + resultado + " de dolares");
        }
        if (moneda == "DOLAR")
        {
            float resultado = Convertir(12);
            Debug.Log("Teniendo, 12 dolares, ahora tienes, " + resultado + " de euros");
        }
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    float Convertir (float cantidad)
    {
        float resultado = 0f;
        if (moneda == "EURO")
        {
            Debug.Log("Tienes " + cantidad + " de euros");
            resultado = cantidad * 1.1124f;
        }
        if (moneda == "DOLAR")
        {
            Debug.Log("Tienes " + cantidad + " de dolares");
            resultado = cantidad * 0.8991f;
        }
        return resultado;
    }

   

   
}
