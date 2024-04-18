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

    //Poner el color del trago en rojo si tengo menos dinero de lo que cuesta y en verde si tengo mas dinero de lo que cuesta
    void Start()
    {
        tragoTexto.text = trago.ToString();
        dineroTexto.text = dinero.ToString();
        if (documento == true)
            documentoTexto.text = "Si";
        else
            documentoTexto.text = "No";
        if (dinero >= trago)
        tragoTexto.color = Color.green;
        else
        tragoTexto.color = Color.red;
    }
}
