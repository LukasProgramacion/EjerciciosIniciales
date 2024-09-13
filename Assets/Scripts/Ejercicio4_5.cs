using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
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

        
        float cantidadDolaresConvertidos = ConvertirEurosADolares(areaCirculoResuelta, "Dolares");
        Debug.Log("Ahora el area del ciruclo, es decir " + areaCirculoResuelta +  " es la cantidad de euros que se pasan a dolares,  quedándonos con un total de " + cantidadDolaresConvertidos + " dolares");
        float cantidadEurosConvertidos = ConvertirDolaresAEuros(areaTringuloResuelta, " Euros");
        Debug.Log("Ahora el area del triangulo es decir, " + areaTringuloResuelta + "  es la cantidad de dolares que se pasan a euros, quedándonos con un total de " + cantidadEurosConvertidos + " euros");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float Circulo(float radio)
    {
        float areaCirculo = (radio * radio) * 3.14f;
        return areaCirculo;
    }

    float Triangulo(float medidaBase, float medidaAltura)
    {
        float areaTriangulo = (medidaBase * medidaAltura) / 2f;
        return areaTriangulo;
    }

    float Cuadrado(float lado)
    {
        float areaCuadrado = lado * lado;
        return areaCuadrado;
    }

    float ConvertirEurosADolares(float cantidadEuros, string moneda)
    {
        float dolaresConvertidos = cantidadEuros * 1.1097f;
        return dolaresConvertidos;
    }

    float ConvertirDolaresAEuros(float cantidadDolares, string moneda)
    {
        float eurosConvertidos = cantidadDolares * 0.9010f;
        return eurosConvertidos;
    }
}
