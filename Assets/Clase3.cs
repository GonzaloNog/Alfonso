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

    private bool borracho = false;
    private int resitenciaAlchol;
    //Variables de UI
    public TextMeshProUGUI documentoTexto;
    public TextMeshProUGUI dineroTexto;
    public TextMeshProUGUI tragoTexto;
    public TextMeshProUGUI tragoTomados;

   // paso 1, funcion que mire si ya superaste tur esistencia a los tragos y en caso de superarla cambiar la variable borracho a True
   // paso 2, No vas a pode pedir mas dinero prestado
   // paso 3, Texto de estado
    void Start()
    {
        resitenciaAlchol = Random.Range(1, 101);
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
            tragoTomados.text = tragosTomadosNumero.ToString();
            dineroTexto.text = dinero.ToString();
        }
        ColorUpdate();
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
    public void ColorUpdate()
    {
        if (dinero >= trago)
            tragoTexto.color = Color.green;
        else
            tragoTexto.color = Color.red;
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
