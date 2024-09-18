    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej5_8 : MonoBehaviour
{
    [SerializeField] int H, M, S;
    //86399
    // Start is called before the first frame update
    void Start()
    {
        if (((H*3600) + (M*59) + S)<86399)
        {
            Debug.Log("La hora introducida es válida: " + H + ": " + M + ":" + S);
        }
        if (((H * 3600) + (M * 59) + S) > 86399)
        {
            Debug.Log("La hora introducida no es válida: " + H + ": " + M + ":" + S);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
