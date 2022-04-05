using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej09 : MonoBehaviour
{
    /* 

    Realizá un programa que resuelva el siguiente problema:
    Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del
    total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
    por las tres.
    Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
    mostrar lo pedido en el siguiente formato:
    Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….

    */ 
    // Start is called before the first frame update
    public string Nombre1,Nombre2,Nombre3;
    public float Capital1,Capital2,Capital3;
    float MontoTotal;
    void Start()
    {
        MontoTotal = Capital1 + Capital2 + Capital3;

        Debug.Log(Nombre1+": Capital aportado: $"+Capital1+", Porcentaje del capital: "+Capital1 * 100 / MontoTotal+"%"+", Monto total aportado: $"+MontoTotal);
        Debug.Log(Nombre2+": Capital aportado: $"+Capital2+", Porcentaje del capital: "+Capital2 * 100 / MontoTotal+"%"+", Monto total aportado: $"+MontoTotal);
        Debug.Log(Nombre3+": Capital aportado: $"+Capital3+", Porcentaje del capital: "+Capital3 * 100 / MontoTotal+"%"+", Monto total aportado: $"+MontoTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
