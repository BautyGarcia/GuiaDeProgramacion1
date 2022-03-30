using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej11 : MonoBehaviour
{
    /* 
    Realizá un programa que resuelva el siguiente problema:
    Deberá ingresarse por Inspector una fecha de compra (String en el siguiente formato:
    YYYYMMDD), un nombre de comprador, un nombre de producto y una cantidad y precio del
    producto comprado. Mostrá a modo de ticket, la información ingresada y el monto a pagar.
    Modelo de Ticket:
    Fecha de Compra: YYYYMMDD
    Nombre del Comprador: xxxxx xxxxx
    Producto solicitado: xxxxx
    Cantidad solicitada: xx
    Precio Unitario: $xxx
    Total a Pagar: $xxxxx   
    
    */
    // Start is called before the first frame update

    public string FechaDeCompra;
    public string NombreComprador;
    public string NombreProducto;
    public int Cantidad;
    public int PrecioUnitario;
    void Start()
    {
        Debug.Log("Fecha de Compra: "+FechaDeCompra);
        Debug.Log("Nombre del Comprador: "+NombreComprador);
        Debug.Log("Producto Solicitado "+NombreProducto);
        Debug.Log("Cantidad Solicitada: "+Cantidad);
        Debug.Log("Precio Unitario: $"+PrecioUnitario);
        Debug.Log("Total a Pagar: $"+(Cantidad*PrecioUnitario));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
