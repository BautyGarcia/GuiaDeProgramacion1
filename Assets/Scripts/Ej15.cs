using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej15 : MonoBehaviour
{
    /* 
    Existen dos reglas que identifican dos conjuntos de valores:
    - El número es de un solo dígito.
    - El número es impar.

    A partir de estas reglas, creá un algoritmo que asigne a las variables booleanas estaEnA, estaEnB, estaEnAmbos y noEstaEnNinguno el valor verdadero o falso, según corresponda,
    para indicar si el valor ingresado pertenece al primer conjunto, al segundo, a ambos o a ninguno, respectivamente. Definí un lote de prueba de varios números y probá el algoritmo,
    escribiendo los resultados.
    */ 
    // Start is called before the first frame update
    public int num1;

    bool estaEnA;
    bool estaEnB;
    bool estaEnAmbos;
    bool estaEnNinguno;
    async void Start()
    {
        if (num1 < 10){
            estaEnA = true;
        }
        else{
            estaEnA = false;
        }

        if (num1%2 != 0){
            estaEnB = true;
        }
        else{
            estaEnB = false;
        }

        if (estaEnA == true && estaEnB == true){
            estaEnAmbos = true;
        }
        else{
            estaEnAmbos = false;
        }

        if (estaEnA == false && estaEnB == false){
            estaEnNinguno = true;
        }
        else{
            estaEnNinguno = false;
        }

        Debug.Log("Esta en A: "+estaEnA);
        Debug.Log("Esta en B: "+estaEnB);
        Debug.Log("Esta en Ambos: "+estaEnAmbos);
        Debug.Log("Esta en Ninguno: "+estaEnNinguno);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
