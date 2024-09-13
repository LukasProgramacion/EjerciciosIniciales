using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float velocidadKm = 90f;
    float velocidadM;
    // Start is called before the first frame update
    void Start()
    {
        velocidadM = velocidadKm * 1000 / 3600;
        Debug.Log("A una velocidad de " + velocidadKm + " km/h, se viaja a " + velocidadM + " m/s");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
