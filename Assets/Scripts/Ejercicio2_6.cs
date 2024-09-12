using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int vida = 12, exp = 24, stamina = 42, media;
    // Start is called before the first frame update
    void Start()
    {
        media = (vida + exp + stamina) / 3;
        Debug.Log("El peronsaje tiene " + vida + " de vida");
        Debug.Log("El peronsaje tiene " + exp + " de exp");
        Debug.Log("El peronsaje tiene " + stamina + " de stamina");
        Debug.Log("El peronsaje tiene " + media + "de media");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
