using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_4 : MonoBehaviour
{
    [SerializeField] int dividendo, divisor;
    float resultadoDivision;
    // Start is called before the first frame update
    void Start()
    {
        if  (divisor != 0)
        {
            resultadoDivision = dividendo / divisor;
            Debug.Log("El dividendo, es " + dividendo + ", y el divisor, es " + divisor + " y, el resultado de la division es " + resultadoDivision);
        }
        else
        {
            Debug.Log("El divisor, " + divisor + " es 0, por lo que no se puede dividir");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
