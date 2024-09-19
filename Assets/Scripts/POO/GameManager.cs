using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Personaje mario;
    [SerializeField] 
    // Start is called before the first frame update
    void Start()
    {
       
    }

   void PrepararPersonajes()
    {
        mario.Vida = 50f;
        mario.Nombre = "Mario";
    }
}
