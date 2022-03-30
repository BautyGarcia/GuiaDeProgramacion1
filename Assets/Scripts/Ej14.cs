using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej14 : MonoBehaviour
{
    /* 
    Construir un programa que simule el funcionamiento de una calculadora que puede realizar las cuatro operaciones aritméticas básicas (suma, resta, producto y división) con
    valores numéricos enteros.

    Se debe especificar la operación que se desea realizar ingresando una letra por Inspector (s para la suma, r para la resta, p para el producto y d para la división) y luego, deberán
    ingresarse dos números enteros para así realizar la operación. Informar el resultado por
    pantalla. Nota: Se recomienda el empleo de una sentencia switch.
    */
    // Start is called before the first frame update
    public string Operacion;
    public int num1;
    public int num2;
    void Start()
    {
        switch(Operacion){
            case "s":
                Debug.Log("El resultado es: "+(num1+num2));
                break;

            case "r":
                if (num2 > num1){
                    Debug.Log("La calculadora no puede mostrar numeros negativos");
                    return;
                }
                Debug.Log("El resultado es: "+(num1-num2));
                break;

            case "p":
                Debug.Log("El resultado es: "+(num1*num2));
                break;

            case "d":
                if (num2 == 0){
                    Debug.Log("No se puede dividir por 0");
                    return;
                }
                Debug.Log("El resultado es: "+(num1/num2));
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
