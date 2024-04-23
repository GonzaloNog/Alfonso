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

    private bool borracho;
    private int resitenciaAlcohol;
    private int MaximoAlcohol = 50;
    //Variables de UI
    public TextMeshProUGUI documentoTexto;
    public TextMeshProUGUI borrachoTexto;
    public TextMeshProUGUI dineroTexto;
    public TextMeshProUGUI tragoTexto;
    public TextMeshProUGUI tragoTomados;

   // paso 1, funcion que mire si ya superaste tu resistencia a los tragos y en caso de superarla cambiar la variable borracho a True
   // paso 2, No vas a pode pedir mas dinero prestado
   // paso 3, Texto de estado
    void Start()
    {
        resitenciaAlcohol = Random.Range(1, 101);
        Debug.Log(resitenciaAlcohol);
        tragoTomados.text = tragosTomadosNumero.ToString();
        dineroTexto.text = dinero.ToString();
        tragoTexto.text = trago.ToString();
        if (borracho == false)
            borrachoTexto.text = "No estas borracho";
        else
            borrachoTexto.text = "Estas borracho";
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
            resitenciaAlcohol++;
            tragoTomados.text = tragosTomadosNumero.ToString();
            dineroTexto.text = dinero.ToString();
        }
        ColorUpdate();
    }
    public void Prestamo()
    {
        if (borracho == false)
        {
            borrachoTexto.text = "No estas borracho";

            if (dinero < trago)
            {
                dinero += 100;
                dineroTexto.text = dinero.ToString();
            }
            else
            {
                Debug.Log("Tienes dinero de sobra");
            }
        }
        else
        {
            Debug.Log("Estas borracho, no pienso prestarte dinero");
        }
    }
    public void ColorUpdate()
    {
        if (dinero >= trago)
            tragoTexto.color = Color.green;
        else
            tragoTexto.color = Color.red;
    }
    public void EstasBorracho()
    {
        if (resitenciaAlcohol >= MaximoAlcohol)
            borracho = true;
        borrachoTexto.text = "Estas borracho";
 
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
