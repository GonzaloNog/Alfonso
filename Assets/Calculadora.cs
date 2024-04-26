using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Calculadora : MonoBehaviour
{
    private string num1;
    private string num2;
    private string Operacion;
    private bool OperacionIniciada = false;

    public TextMeshProUGUI ResultadoTexto;

    
    public void apretarBoton(string numero)
    {
        if(OperacionIniciada == true)
        {
            num2 += numero;
            ResultadoTexto.text = num2.ToString();
        }
        else
        {
            num1 += numero;
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
                ResultadoTexto.text = (float.Parse(num1) + float.Parse(num2)).ToString();
                break;
            case "-":
                ResultadoTexto.text = (float.Parse(num1) - float.Parse(num2)).ToString();
                break;
            case "*":
                ResultadoTexto.text = (float.Parse(num1) * float.Parse(num2)).ToString(); 
                break;
            case "/":
                ResultadoTexto.text = (float.Parse(num1) / float.Parse(num2)).ToString();
                break;
        }
        num1 = "";
        num2 = "";
        OperacionIniciada = false;
    }
    public void ResetCalculadora()
    {
        num1 = "";
        num2 = "";
        OperacionIniciada = false;
    }

}
