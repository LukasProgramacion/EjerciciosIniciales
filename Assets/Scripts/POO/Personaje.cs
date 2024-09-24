using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    
    [SerializeField] Arma miArma;
    [SerializeField] Personaje2 enemigo;
    [SerializeField] KeyCode TeclaCurarseJugador1 = KeyCode.H, TeclaDanharJugador1 = KeyCode.C;


    //[SerializeField] bool miTurno = true;
    [SerializeField] float vidaInicial = 10f;
    float vida, experiencia, vidaActual;
    string nombre;

    #region getters and setters
    public float Vida { get => vida; set => vida = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public float VidaActual { get => vidaActual; set => vidaActual = value; }
    public bool MiTurno { get => miTurno; set => miTurno = value; }
    #endregion

    void Start()
    {
        vidaActual = vidaInicial;     
    }

    public float CalcularNivel()
    {
        float nivel = experiencia / 100f;

        return nivel;

    }

    float RecibirCura (float cantidad)
    {
        if (Input.GetKeyDown(TeclaCurarseJugador1))
        {
            if (cantidad >= 0)
            {
                vidaActual = vidaActual + cantidad;
            }
            else
            {
                vidaActual = -1;
            }

           

        }
        return vidaActual;

    }

    float HacerDanho (float danhoRealizado)
    {
        if (miArma.MunicionRestada > 0)
        {
            if (Input.GetKeyDown(TeclaDanharJugador1))
            {
                danhoRealizado = miArma.DanhoMaximo;
                enemigo.VidaActual = -danhoRealizado;
            }

            
        }
        else
        {
            Debug.Log("Reload!!!");

            if (Input.GetKeyDown(KeyCode.R))
            {
                miArma.RecargarArma();

                if (miArma.MunicionActual == miArma.CapacidadTotal)
                {
                    Debug.Log("Arma ya cargada");
                }
            }
        }
        return danhoRealizado;


    }



    float RecibirDanho (float danho)
    {
        if (danho >= 0)
        {
            vidaActual = vidaActual - miArma.CantidadDanhoRealizado;
        }
        else
        {
            vidaActual = -1;
        }

        return vidaActual;
    }

    void Atacar ()
    {

    }

    void Saltar ()
    {

    }
}
