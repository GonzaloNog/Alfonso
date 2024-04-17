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
    //Variables de UI
    public TextMeshProUGUI documentoTexto;
    public TextMeshProUGUI dineroTexto;
    public TextMeshProUGUI tragoTexto;
    void Start()
    {
        tragoTexto.text = trago.ToString();
        dineroTexto.text = dinero.ToString();
        if (documento == true)
            documentoTexto.text = "Si";
        else
            documentoTexto.text = "No";

        tragoTexto.color = Color.red;
    }
}
