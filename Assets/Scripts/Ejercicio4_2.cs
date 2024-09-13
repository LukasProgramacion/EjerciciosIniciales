using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string darNombreCompleto = ConstruirNombre("Lucas ", " de Miguel", " López");
        Debug.Log(darNombreCompleto);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string ConstruirNombre (string nombre, string apellido1, string apellido2)
    {
        string NombreCompleto = " Tu nombre  es " + nombre + apellido1 + apellido2 + " y tienes 20 años";
        return NombreCompleto;
    }
}
