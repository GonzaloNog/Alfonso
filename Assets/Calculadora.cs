using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Calculadora : MonoBehaviour
{
    private int num1;
    private int num2;
    private string Operacion;
    private bool OpereacionIniciada = false;

    public TextMeshProUGUI ResultadoTexto;

    
    public void apretarBoton(int numero)
    {
        if(OpereacionIniciada == true)
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
        OpereacionIniciada = true;
        Operacion = _operacion;
        ResultadoTexto.text = Operacion;
    }
    public void mostrarResultado()
    {
        switch(Operacion)
        {
            case "+":
                ResultadoTexto.text = (num1 + num2).ToString();
                OpereacionIniciada = false;
                break;
        }
    }

}
