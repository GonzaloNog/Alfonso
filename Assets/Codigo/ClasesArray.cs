using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClasesArray : MonoBehaviour
{
    public int[] arrayEntero;
    void Start()
    {
        //cantidad de elementos
        Debug.Log(arrayEntero.Length);
        Debug.Log(arrayEntero[3]);
        arrayEntero[3] = 20;
        Debug.Log(arrayEntero[3]);
    }
}
