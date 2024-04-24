using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Calculadora : MonoBehaviour
{
    private int num1;
    private int num2;
    private string Operacion;

    public TextMeshProUGUI ResultadoTexto;

    //crea 10 botones cada uno corresponde a un numero, al apretarlo agrega al primer numero un valor
    //Luego de elegir la operacion cuando se vuelva a clickear un boton, tenemos que asignar un valor a la variable numero 2
    public void apretarBoton(int numero)
    {
        if (Operacion != null && num2 == 0)
        {
            num2 = numero;
            ResultadoTexto.text = num2.ToString();
            
        }
        else
        {
            num1 = numero;
            ResultadoTexto.text = num1.ToString();
           
        }
    }
        public void operacionFuncion(string _operacion)
    { 
        Operacion = _operacion;
       
    }    

}
