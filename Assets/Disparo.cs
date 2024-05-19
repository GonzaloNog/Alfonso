using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Disparo 
{
    private int damage;
    private Color col;

    public Disparo(Color _col)
    {
        col = _col;
    }

    public Color getColor()
    {
        return col;
    }
    public int getDamage()
    {
        return damage;
    }
    public abstract int Impact();
}
