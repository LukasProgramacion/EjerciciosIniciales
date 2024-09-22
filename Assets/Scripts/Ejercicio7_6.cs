using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int numMinimo = 1, numMaximo = 150;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = numMinimo; i <= numMaximo; i++)
        {
            Debug.Log("(7_6) El numero en este caso (for) es " + i);
        }
        while (numMinimo <= numMaximo)
        {
            Debug.Log("(7_6) El numero en este caso (while) es " + numMinimo);
            numMinimo++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
