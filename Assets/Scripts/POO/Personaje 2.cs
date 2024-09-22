using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje2 : MonoBehaviour
{
    [SerializeField] Arma2 miArma2;
    [SerializeField] Personaje enemigo;
    
    [SerializeField] float vidaInicial = 10f;
    float vida, experiencia, vidaActual;
    string nombre;

    #region getters and setters
    public float Vida { get => vida; set => vida = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    #endregion

    public float CalcularNivel()
    {
        float nivel = experiencia / 100f;

        return nivel;

    }

    float RecibirCura(float cantidad)
    {
        if (cantidad >= 0)
        {
            vidaActual = vidaInicial + cantidad;
        }
        else
        {
            vidaActual = -1;
        }

        return vidaActual;

    }

    float RecibirDanho(float danho)
    {
        if (danho >= 0)
        {
            vidaActual = vidaInicial - danho;
        }
        else
        {
            vidaActual = -1;
        }

        return vidaActual;
    }

    void Atacar()
    {

    }

    void Saltar()
    {

    }
}
