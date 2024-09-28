using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    [SerializeField] int numMinimo = 1, numMaximo = 10;
    int suma;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = numMinimo; i <= numMaximo; i++)
        {
            suma += i;
        }
        Debug.Log("(7_12) La suma entre los numeros " + numMinimo + " y " + numMaximo + " es " + suma);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
