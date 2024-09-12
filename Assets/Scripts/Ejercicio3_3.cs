using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numeroEntero = 5, doble, triple;
    // Start is called before the first frame update
    void Start()
    {
        doble = numeroEntero * 2;
        triple = numeroEntero * 3;
        Debug.Log("Doble de numero entero " + doble);
        Debug.Log("Triple de numero entero " + triple);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
