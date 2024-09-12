using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    int horas = 4, numeroTotalDeOro;
    // Start is called before the first frame update
    void Start()
    {
        numeroTotalDeOro = horas * 60 * 60 * 7;
        Debug.Log("Un personaje farmea 7 unidades de oro por segundo, es decir que en 4 horas ha farmeado " + numeroTotalDeOro + " de oro");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
