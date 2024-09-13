using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercico4_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float areaCirculoResuelta = Circulo(6);
        Debug.Log("Con 6cm de radio, el area del ciruclo es de " + areaCirculoResuelta + " cm^2");
        float areaTringuloResuelta = Triangulo(15, 40);
        Debug.Log("Con 15cm de base y 40cm de altura, el area del triangulo es de " + areaTringuloResuelta + " cm^2");
        float areaCuadradoResuelta = Cuadrado(20);
        Debug.Log("Con 20cm de lado, el area del cuadrado es de " + areaCuadradoResuelta + " cm^2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float Circulo (float radio)
    {
        float areaCirculo = (radio * radio) * 3.14f;
        return areaCirculo;
    }

    float Triangulo (float medidaBase, float medidaAltura)
    {
        float areaTriangulo = (medidaBase * medidaAltura) / 2f;
        return areaTriangulo;
    }

    float Cuadrado (float lado)
    {
        float areaCuadrado = lado * lado;
        return areaCuadrado;
    }
}
