using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Personaje mario;
    [SerializeField] Personaje2 link;
    [SerializeField] bool yaEjectuado = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

   void PrepararPersonajes()
    {
        if (Input.GetKeyDown(KeyCode.Space) && yaEjectuado == false) 
        {
            mario.Vida = 50f;
            mario.Nombre = "Mario";

            link.Vida = 100f;
            link.Nombre = "Link";

            yaEjectuado = true;
        }

    }
}
