using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] float medidaBase = 20f, medidaAltura = 15f;
    float areaTriangulo;
    // Start is called before the first frame update
    void Start()
    {
        areaTriangulo = (medidaBase * medidaAltura) / 2f;
        Debug.Log("Con " + medidaBase + " cm de base y" + medidaAltura + " cm de altura, tenemos un area en el triangulo de " + areaTriangulo + " cm^2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
