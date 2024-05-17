using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase2 : MonoBehaviour
{
    public int edad;
    public bool trabajo;
    public int euros;
    
    void Start()
    {
        if (edad >= 18)
        {
            if (trabajo == true)
            {
                if (euros >= 1000)
                    Debug.Log("Cuenta abierta");
                else
                    Debug.Log("No tienes dinero suficiente, Necesitas: "+(1000 -euros)+" mas");
            }
            else
                Debug.Log("Necesitas tener un trabajo");
        }
        else
            Debug.Log("No tienes la edad suficiente, Necesitas: "+(18 -edad)+" años mas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
