using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] int numMinimo = 1, numMaximo = 130;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = numMinimo; i <= numMaximo; i++)
        {
            Debug.Log("(7_7) El numero en este caso es " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
