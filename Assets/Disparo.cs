using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Disparo 
{
    private int damage;
    private Sprite sprit;

    public Disparo(Sprite _sprite)
    {
        sprit = _sprite;
    }

    public Sprite getSprite()
    {
        return sprit;
    }
    public int getDamage()
    {
        return damage;
    }
    public abstract int Impact();
}
