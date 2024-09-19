using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    float vida, experiencia;
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

    void Atacar ()
    {

    }

    void Saltar ()
    {

    }
}
