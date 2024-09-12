using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1 = 15, vidasPlayer2 = 30, vidasPlayer3 = 45, vidasPlayer4 = 60, nuevoValorVidasPlayer;  
    // Start is called before the first frame update
    void Start()
    {
        vidasPlayer2 = vidasPlayer3;
        nuevoValorVidasPlayer = vidasPlayer2;
        Debug.Log("Vidas player 2= " +  vidasPlayer2);
        vidasPlayer3 = vidasPlayer1;
        nuevoValorVidasPlayer = vidasPlayer3;
        Debug.Log("Vidas player 3= " + vidasPlayer3);
        vidasPlayer1 = vidasPlayer4;
        nuevoValorVidasPlayer = vidasPlayer1;
        Debug.Log("Vidas player 1= " + vidasPlayer1);
        vidasPlayer4 = vidasPlayer3;
        nuevoValorVidasPlayer = vidasPlayer4;
        Debug.Log("Vidas player 4= " + vidasPlayer4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
