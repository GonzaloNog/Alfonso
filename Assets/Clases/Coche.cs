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

    public override void ArrancarCoche()
    {
        Debug.Log("Esto es un coche");
    }

    public override void ArrancarMoto()
    {
        throw new System.NotImplementedException();
    }

    // Hazme 2 clases nuevas que hereden de transporte en cada una de estas hay que crearla una variable especifica de cada clase con set y getters
}

public class Moto : Transporte
{
    private string color;
    public Moto(int _maxSpeed, bool _publico, int _capacidad, string _color) : base(_maxSpeed, _publico, _capacidad)
    {
        color = _color;
    }
    public void setcolor(string _color)
    {
        color = _color;
    }

    public string getcolor()
    {
        return color;
    }

    public override void ArrancarMoto()

    {
        Debug.Log("Esto es una moto");
    }

    public override void ArrancarCoche()
    {
        throw new System.NotImplementedException();
    }
}



