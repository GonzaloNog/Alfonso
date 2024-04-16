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

        }
        else
            Debug.Log("Tenes que ser mayor de edad");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
