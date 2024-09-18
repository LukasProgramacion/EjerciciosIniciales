using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_10 : MonoBehaviour
{
    [SerializeField] int Temp;
    // Start is called before the first frame update
    void Start()
    {
        if (Temp <= 10)
        {
            Debug.Log("El clima es frío");
        }
        if (Temp > 10 && Temp <= 20)
        {
            Debug.Log("El clima es nublado");
        }
        if (Temp > 20 && Temp <= 30)
        {
            Debug.Log("El clima es caluroso");
        }
        if (Temp > 30)
        {
            Debug.Log("El clima es tropical");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
