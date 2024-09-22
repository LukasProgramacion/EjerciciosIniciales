using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma2 : MonoBehaviour
{
    [SerializeField] float danhoMinimo = 10f, danhoMaximo = 100f, capacidadTotal = 200f;
    [SerializeField] bool automatica = false;
    float municionActual = 15f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    float UtilizarArma(float cantidad = 1f)
    {
        if (municionActual > 0)
        {
            float municionRestada = municionActual - cantidad;
            return municionRestada;
        }
        else
        {
            municionActual = -1f;
            return municionActual;
        }
    }
    float RecargarArma()
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
