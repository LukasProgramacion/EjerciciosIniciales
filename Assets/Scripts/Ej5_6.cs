using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_6 : MonoBehaviour
{
    [SerializeField] int nivel = 60;
    // Start is called before the first frame update
    void Start()
    {
        if (nivel%10 == 0)
        {
            Debug.Log("El nivel del pokemon, " + nivel + " es multiplo de 10");
        }
        if (nivel%10 != 0)
        {
            Debug.Log("El nivel del pokemon, " + nivel + " no es multiplo de 10");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
