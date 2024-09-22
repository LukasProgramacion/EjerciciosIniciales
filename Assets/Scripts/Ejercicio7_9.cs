using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{
    [SerializeField] int numMinimo = 1, numMaximo = 50;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = numMinimo; i <= numMaximo; i++)
        {
            if (i % 3 == 0)
            {
                Debug.Log("(7_9) El numero multiplo de 3 en este caso es " + i);
            }


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
