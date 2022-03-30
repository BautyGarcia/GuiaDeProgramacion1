using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej05 : MonoBehaviour
{
    /* 
    Realizá un programa que, dados dos números enteros num1 y num2 cargados desde el
    Inspector muestre el resultado de la división del primero por el segundo en la consola
    siguiendo el formato num1 + “ / “ + num2 + “ = “ + resultado.
    En el caso de que el segundo valor num2 sea cero, mostrar el siguiente mensaje de error:
    “No se puede dividir por cero”.
    */ 
    // Start is called before the first frame update
    public int num1;
    public int num2;
    void Start()
    {
        if (num2 == 0){
            Debug.Log("No se puede dividir por cero");
            return;
        }
        else {
            Debug.Log(num1+" / "+num2+" da como resultado "+(num1/num2));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
