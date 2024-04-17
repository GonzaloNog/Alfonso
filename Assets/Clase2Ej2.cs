using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class Clase2Ej2 : MonoBehaviour
{
    //Tener 3 variables publicas, edad, documento, dinero, ver si podemos entrar a la discoteca, y tomar un trago
    public int edad;
    public bool documento;
    public int dinero;
    public int trago = 8;

    void Start()
    {
        if (edad >= 18 && documento == true)
        {
            if (dinero >= trago)
                Debug.Log("Has entrado en la discoteca y puedes tomarte un trago");
            else
                Debug.Log("Has entrado en la discoteca pero no puedes tomarte un trago");
        }
        else
            Debug.Log("No puedes entrar!");
    }

}
