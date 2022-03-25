using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej02 : MonoBehaviour
{
    /* 2. Realizá un programa que, siendo num1 y num2 variables enteras con valores 4 y 5,  respectivamente, realice la operación correspondiente y muestre el resultado en pantalla: 
    a. Suma 
    b. Producto 
    */
    // Start is called before the first frame update
    int num1 = 4;
    int num2 = 5;
    void Start()
    {
        Debug.Log("4 + 5 = "+(num1+num2));
        Debug.Log("4 * 5 = "+(num1*num2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
