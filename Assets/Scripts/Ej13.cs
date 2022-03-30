using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej13 : MonoBehaviour
{
    /* 
    Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera:
    • Si trabaja 40 horas o menos se le paga $16 por hora (crear una constante para almacenar el 16)
    • Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20 por cada hora extra. (crear una constante para almacenar el 20)
    Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla el salario correspondiente.
    */
    // Start is called before the first frame update\
    const int LessThan40 = 16;
    const int MoreThan40 = 20;
    public int CantHoras;
    void Start()
    {
        if (CantHoras <= 40){
            Debug.Log("El salario correspondiente es "+(CantHoras*LessThan40));
        }
        else {
            CantHoras -= 40;
            Debug.Log("El saalrio correspondiente es "+(40*LessThan40+MoreThan40*CantHoras));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
