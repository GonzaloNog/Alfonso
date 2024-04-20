using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clase3 : MonoBehaviour
{
    //Variables normales
    public int edad;
    public bool documento;
    public int dinero;
    public int trago = 8;
    private int tragosTomadosNumero = 0;
    //Variables de UI
    public TextMeshProUGUI documentoTexto;
    public TextMeshProUGUI dineroTexto;
    public TextMeshProUGUI tragoTexto;
    public TextMeshProUGUI tragoTomados;

    //Poner el color del trago en rojo si tengo menos dinero de lo que cuesta y en verde si tengo mas dinero de lo que cuesta
    void Start()
    {
        tragoTomados.text = tragosTomadosNumero.ToString();
        dineroTexto.text = dinero.ToString();
        tragoTexto.text = trago.ToString();
        if (documento == true)
            documentoTexto.text = "Si";
        else
            documentoTexto.text = "No";
    }
    public void comprarTrago()
    {
        if (dinero >= trago)
        {
            dinero -= trago;
            tragosTomadosNumero++;
            tragoTexto.color = Color.green;
            tragoTomados.text = tragosTomadosNumero.ToString();
            dineroTexto.text = dinero.ToString();
        }
        else
            tragoTexto.color = Color.red;
    }
    public void Prestamo()
    {
        if (dinero < trago)
        {
            dinero += 100;
            dineroTexto.text = dinero.ToString();
        }
        else
            Debug.Log("Tienes dinero de sobra");
    }
}

/*
 tragoTexto.text = trago.ToString();
        dineroTexto.text = dinero.ToString();
        if (documento == true)
            documentoTexto.text = "Si";
        else
            documentoTexto.text = "No";


 * */
