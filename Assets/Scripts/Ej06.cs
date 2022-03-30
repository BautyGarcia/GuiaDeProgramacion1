using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej06 : MonoBehaviour
{
    /* 
    Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0
    en una variable llamada num1 y muestre un mensaje por pantalla indicando &quot;el número es
    par&quot; o &quot;el número es impar&quot;. Deberá utilizar el operador “módulo” es el caracter %.
    */ 
    // Start is called before the first frame update
    public int num1;
    void Start()
    {
        if (num1 <= 0){
            Debug.Log("El numero ingresado no es valido");
            return;
        }
        else {
            if(num1%2 == 0){
                Debug.Log("El numero es par");
            }
            else{
                Debug.Log("El numero es impar");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
