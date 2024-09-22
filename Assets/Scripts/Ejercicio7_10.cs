using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_10 : MonoBehaviour
{
    [SerializeField] int numMinimo = -10, numMaximo = 60;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = numMinimo; i <= numMaximo; i++)
        {
           if (i* -1 < 0 &&  i%2 == 0)
            {
                Debug.Log("(7_10) El numero, " + i + " es positivo y par");
            }
           if (i* -1 < 0 && i%2 != 0)
            {
                Debug.Log("(7_10) El numero, " + i + " es positivo e impar");
            }
           if(i*-1 > 0 && i%2 == 0)
            {
                Debug.Log("(7_10) El numero, " + i + " es negativo y par");
            }
           if(i*-1 > 0 && i%2 != 0)
            {
                Debug.Log("(7_10) El numero, " + i + " es negativo e impar");
            }


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
