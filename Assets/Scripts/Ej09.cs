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
    public string nom1,nom2,nom3;
    int por1,por2,por3;
    public int cap1,cap2,cap3;
    int MontoTotal;
    void Start()
    {
        MontoTotal = cap1 + cap2 + cap3;

        por1 = cap1 * 100 / MontoTotal;
        por2 = cap2 * 100 / MontoTotal;
        por3 = cap3 * 100 / MontoTotal;

        Debug.Log(nom1+": Capital aportado: $"+cap1+", Porcentaje del capital: "+por1+"%");
        Debug.Log(nom2+": Capital aportado: $"+cap2+", Porcentaje del capital: "+por2+"%");
        Debug.Log(nom3+": Capital aportado: $"+cap3+", Porcentaje del capital: "+por3+"%");
        Debug.Log("Monto total aportado: $"+MontoTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
