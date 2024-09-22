using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int numMinimo = 1, numMaximo = 50;
    // Start is called before the first frame update
    void Start()
    {
 
        for (int i = numMinimo; i <= numMaximo; i++)
        {
            if(i%2 == 0)
            {
                Debug.Log("(7_8) El numero par en este caso es " + i);
            }


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
