using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_5 : MonoBehaviour
{
    [SerializeField] int nivel = 5;
    // Start is called before the first frame update
    void Start()
    {
        if (nivel%2 == 0)
        {
            Debug.Log("El nivel del personaje, " + nivel + " es par");
        }
        if (nivel%2 != 0)
        {
            Debug.Log("El nivel del personaje, " + nivel + " es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
