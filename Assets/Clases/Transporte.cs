using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Transporte 
{
    protected int maxSpeed;
    protected bool publico;
    protected int capacidad;

    public Transporte()
    {
        maxSpeed = 5;
        publico = false;
        capacidad = 4;
    }
    public Transporte(int _maxSpeed, bool _publico, int _capacidad)
    {
        maxSpeed = _maxSpeed;
        publico = _publico;
        capacidad= _capacidad;
    }

    public void setMaxSpeed(int _maxSpeed) 
    {
        maxSpeed = _maxSpeed;
    }
    public int getMaxSpeed()
    {
        return maxSpeed;
    } 

    public void setpublico(bool _publico)
    {
        publico = _publico;
    }
    public bool getpublico() 
    { 
        return publico;
    }

    public void setcapacidad(int _capacidad)
    {
        capacidad = _capacidad;
    }


    public int getcapacidad()
    {
        return capacidad;
    }

}
