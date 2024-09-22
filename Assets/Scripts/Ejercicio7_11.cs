using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
    [SerializeField] int numero = 2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("(7_11) En la tabla de multiplicar del " + numero + " el primero es " + numero * 1);
        Debug.Log("(7_11) En la tabla de multiplicar del " + numero + " el segundo es " + numero * 2);
        Debug.Log("(7_11) En la tabla de multiplicar del " + numero + " el tercero es " + numero * 3);
        Debug.Log("(7_11) En la tabla de multiplicar del " + numero + " el cuarto es " + numero * 4);
        Debug.Log("(7_11) En la tabla de multiplicar del " + numero + " el quinto es " + numero * 5);
        Debug.Log("(7_11) En la tabla de multiplicar del " + numero + " el sexto es " + numero * 6);
        Debug.Log("(7_11) En la tabla de multiplicar del " + numero + " el septimo es " + numero * 7);
        Debug.Log("(7_11) En la tabla de multiplicar del " + numero + " el octavo es " + numero * 8);
        Debug.Log("(7_11) En la tabla de multiplicar del " + numero + " el noveno es " + numero * 9);
        Debug.Log("(7_11) En la tabla de multiplicar del " + numero + " el décimo es " + numero * 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
