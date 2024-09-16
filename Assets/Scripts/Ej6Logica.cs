using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej6Logica : MonoBehaviour
{
    /*
    X = true, Y = false, Z = true
    a) (X && Y) || (X && Z) => true
    b) (X || !Y) && (!X || Z) => true && true => true
    c) X || Y && Z => true
    d) ! (X || Y) && Z => false && true => false
    e) X || Y || X && !Z && !Y => true || false || false && true => true || false || false => true
    f) !X || !Y || Z && X && !Y => false || true || true && true => false || true || true => true


    W = false, X = true, Y = true, Z= false
    a) W || Y && X && W || Z => false || false || true => true
    b) X && !Y && !X || !W && Y =>  false || true => true
    c) ! (W || !Y) && X || Z => true || flase => true
    d) X && Y && W || Z || W => false || false || false => false
    e) Y || !(Y || Z && W)  => true || flase => true
    f) !X && Y && (!Z || !X) => false && true && false => false


    */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
