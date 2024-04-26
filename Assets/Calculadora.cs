using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Calculadora : MonoBehaviour
{
    private float num1;
    private float num2;
    private string Operacion;
    private bool OperacionIniciada = false;

    public TextMeshProUGUI ResultadoTexto;

    
    public void apretarBoton(float numero)
    {
        if(OperacionIniciada == true)
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
        OperacionIniciada = true;
        Operacion = _operacion;
        ResultadoTexto.text = Operacion;
    }
    public void mostrarResultado()
    {
        switch(Operacion)
        {
            case "+":
                ResultadoTexto.text = (num1 + num2).ToString();
                OperacionIniciada = false;
                break;
            case "-":
                ResultadoTexto.text = (num1 - num2).ToString();
                OperacionIniciada = false;
                break;
            case "*":
                ResultadoTexto.text = (num1 * num2).ToString();
                OperacionIniciada = false; 
                break;
            case "/":
                ResultadoTexto.text = (num1 / num2).ToString();
                OperacionIniciada = false;
                break;
        }
    }

}
