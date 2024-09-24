using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    //public System.Random cantidadDanhoRealizado;
    [SerializeField] float danhoMinimo = 10f, danhoMaximo = 100f, capacidadTotal = 200f;
    [SerializeField] bool automatica = false;
    float municionActual = 15f, cantidadDanhoRealizado, municionRestada;

    public float DanhoMaximo { get => danhoMaximo; set => danhoMaximo = value; }
    public float MunicionRestada { get => municionRestada; set => municionRestada = value; }
    public float CantidadDanhoRealizado { get => cantidadDanhoRealizado; set => cantidadDanhoRealizado = value; }
    public float MunicionActual { get => municionActual; set => municionActual = value; }
    public float CapacidadTotal { get => capacidadTotal; set => capacidadTotal = value; }

    // Start is called before the first frame update
    void Start()
    {
        cantidadDanhoRealizado = Random.Range(danhoMinimo, danhoMaximo + 1);
        municionActual = capacidadTotal;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float UtilizarArma (float cantidad = 1f)
    {
        if (municionActual > 0)
        {
            municionRestada = municionActual - cantidad;
            municionRestada = 0;
            return municionRestada;

        }
        else
        {
            municionActual = -1f;
            return municionActual;
        }
    }
    public float RecargarArma ()
    {
        if (municionActual != capacidadTotal)
        {
            municionActual = capacidadTotal;
            return municionActual;
        }
        else
        {
            municionActual = -1f;
            return municionActual;
        }
    }
}
