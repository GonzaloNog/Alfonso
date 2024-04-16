using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase2 : MonoBehaviour
{
    public int edad;
    void Start()
    {
        if (edad >= 18)
            Debug.Log("Es mayor de edad");
        else
            Debug.Log("Es menor de edad");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
