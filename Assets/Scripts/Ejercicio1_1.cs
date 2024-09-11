using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_1 : MonoBehaviour
{
    //Declarar variables
    int vida = 50;
    float porcentajeAcierto;
    bool quemado;
    string explorador;
    char solucionPuzle;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("¡Hola mundo!");
        Debug.Log("Este es el primer videojuego de Lucas");
        Debug.Log("Estoy aprendiendo C#");
    }

    // Update is called once per frame
    void Update()
    {
        //El mensaje "ha pasado un frame" se muestra cada frame porque esta dentro de la función de "void Update", la cual ejectua el codigo que tenga entre sus llaves ({}) una vez por frame.
        Debug.Log("Ha pasado un frame");
    }
}
