using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    [SerializeField] float puntosExp = 50f;
    float nivel;
    // Start is called before the first frame update
    void Start()
    {
        nivel = 32 + (9 * puntosExp / 5);
        Debug.Log("Con 50 puntos de experiencia, eres de nivel " + nivel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
