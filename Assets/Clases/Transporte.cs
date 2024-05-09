using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Transporte 
{
    protected int maxSpeed;
    protected bool publico;

    public Transporte()
    {
        maxSpeed = 5;
        publico = false;
    }
    public Transporte(int _maxSpeed, bool _publico)
    {
        maxSpeed = _maxSpeed;
        publico = _publico;
    }

    public void setMaxSpeed(int _maxSpeed) 
    {
        maxSpeed = _maxSpeed;
    }
    public int getMaxSpeed()
    {
        return maxSpeed;
    } 
}
