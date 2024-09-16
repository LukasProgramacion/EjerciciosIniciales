using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    [SerializeField] string moneda;
    // Start is called before the first frame update
    void Start()
    {
        float areaCirculoResuelta = Circulo(6);
        Debug.Log("Con 6cm de radio, el area del ciruclo es de " + areaCirculoResuelta + " cm^2");
        float areaTringuloResuelta = Triangulo(15, 40);
        Debug.Log("Con 15cm de base y 40cm de altura, el area del triangulo es de " + areaTringuloResuelta + " cm^2");
        float areaCuadradoResuelta = Cuadrado(20);
        Debug.Log("Con 20cm de lado, el area del cuadrado es de " + areaCuadradoResuelta + " cm^2");

        if (moneda == "EURO")
        {
            float resultado = Convertir(areaCirculoResuelta);
            Debug.Log("Usando el area del circulo, que es, " + areaCirculoResuelta + " como cantidad de euros, se convierte a " + resultado + " de dolares");
        }
        if (moneda == "DOLAR")
        {
            float resultado = Convertir(areaCuadradoResuelta);
            Debug.Log("Usando el area el cuadrado, que es " + areaCuadradoResuelta + " como cantidad de dolares, se convierte a " + resultado + " de euros");
        }
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

    float Convertir(float cantidad)
    {
        float resultado = 0f;
        if (moneda == "EURO")
        {
            Debug.Log("Tienes " + cantidad + " de euros");
            resultado = cantidad * 1.1124f;
        }
        if (moneda == "DOLAR")
        {
            Debug.Log("Tienes " + cantidad + " de dolares");
            resultado = cantidad * 0.8991f;
        }
        return resultado;
    }
}
