using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numeroMaximo = 150;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= numeroMaximo; i++)
        {
            Debug.Log("(7_5) El numero actual esta vez es " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
