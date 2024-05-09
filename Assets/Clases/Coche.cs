using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coche : Transporte
{
    private string marca;
    public Coche(int _maxSpeed, bool _publico, int _capacidad, string _marca) : base (_maxSpeed, _publico, _capacidad)
    {
        marca = _marca;
    }

    public void setmarca(string _marca)
    {
        marca = _marca;
    }

    public string getmarca() 
    { 
        return marca;
    }
}


