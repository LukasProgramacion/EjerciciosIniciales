using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Ej5_3 : MonoBehaviour
{
    [SerializeField] int numero;
    // Start is called before the first frame update
    void Start()
    {
        if (numero >=0 && numero <= 9)
        {
            Debug.Log("El numero, " + numero + " , está comprendido entre el 0 y el 9");
        }
        else
        {
            Debug.Log("El numero, " + numero + " , no está comprendido entre el 0 y el 9");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
