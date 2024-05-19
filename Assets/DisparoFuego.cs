using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoFuego : Disparo
{
    public DisparoFuego() : base(Color.red)
    {

    }
    public override int Impact()
    {
        return 15;
    }
}
public class DisparoHielo : Disparo
{
    public DisparoHielo() : base(Color.blue) 
    {

    }
    public override int Impact()
    {
        return 25;
    }
}
public class DisparoTierra : Disparo
{
    public DisparoTierra() : base(Color.black)
    {

    }
    public override int Impact() { return 40; }
}
