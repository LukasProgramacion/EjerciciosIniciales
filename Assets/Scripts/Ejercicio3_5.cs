using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    // perimetro = pi * diametro, area = pi * radio2
    [SerializeField] float radio = 5; 
    float longitud, area;
    // Start is called before the first frame update
    void Start()
    {
        longitud = (2f*radio)*3.14f;
        area = (radio * radio) * 3.14f;
        Debug.Log("Longitud de la cincurferencia de radio " + radio + " es " + longitud);
        Debug.Log("Area de la cincurferencia de radio " + radio + " es " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
