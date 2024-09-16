using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_2 : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 < 3 && numero2 < 3)
        {
           Debug.Log("El primer numero, " + numero1 + " y el segundo, " +  numero2 + " ,son ambos menores que 3");
        }
        else
        {
            Debug.Log("Los 2 numeros: " + numero1 + " y " + numero2 + " no son menores de 3");            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
