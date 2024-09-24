using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje2 : MonoBehaviour
{
    [SerializeField] Arma2 miArma2;
    [SerializeField] Personaje enemigo;
    [SerializeField] KeyCode TeclaCurarseJugador2 = KeyCode.J, TeclaDanharJugador2 = KeyCode.V;

    [SerializeField] float vidaInicial = 10f;
    float vida, experiencia, vidaActual;
    string nombre;

    #region getters and setters
    public float Vida { get => vida; set => vida = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public float VidaActual { get => vidaActual; set => vidaActual = value; }
    #endregion

    public float CalcularNivel()
    {
        float nivel = experiencia / 100f;

        return nivel;

    }

    float RecibirCura(float cantidad)
    {
        if (Input.GetKeyDown(TeclaCurarseJugador2))
        {
            if (cantidad >= 0)
            {
                vidaActual = vidaInicial + cantidad;
            }
            else
            {
                vidaActual = -1;
            }
        }
        

        return vidaActual;

    }

    float HacerDanho(float danhoRealizado)
    {
        if (miArma2.MunicionRestada > 0)
        {
            if (Input.GetKeyDown(TeclaDanharJugador2))
            {
                danhoRealizado = miArma2.DanhoMaximo;
                enemigo.VidaActual = -danhoRealizado;
            }


        }
        else
        {
            Debug.Log("Reload!!!");

            if (Input.GetKeyDown(KeyCode.R))
            {
                miArma2.RecargarArma();

                if (miArma2.MunicionActual == miArma2.CapacidadTotal)
                {
                    Debug.Log("Arma ya cargada");
                }
            }
        }
        return danhoRealizado;

    }

    float RecibirDanho(float danho)
    {
        if (danho >= 0)
        {
            vidaActual = vidaInicial - miArma2.CantidadDanhoRealizado; 
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
