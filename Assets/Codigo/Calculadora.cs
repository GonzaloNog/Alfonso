using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Calculadora : MonoBehaviour
{
    private string num1;
    private string num2;
    private List<string> listNumeros;
    private List<string> operadores;
    private string Operacion;

    public TextMeshProUGUI ResultadoTexto;

    private void Start()
    {
        listNumeros = new List<string>();
        operadores = new List<string>();
    }
    public void apretarBoton(string numero)
    {
        if(listNumeros.Count == (operadores.Count + 1) || listNumeros.Count == 0)
        {
            listNumeros.Add(numero);
        }
    }
    public void operacionFuncion(string _operacion)
    {
        if (listNumeros.Count > operadores.Count)
        {
            operadores.Add(_operacion);
            ResultadoTexto.text = _operacion;
        }
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
    }
    public void ResetCalculadora()
    {
        num1 = "";
        num2 = "";
    }

}
