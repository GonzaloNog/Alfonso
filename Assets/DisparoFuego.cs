using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoFuego : Disparo
{
    public DisparoFuego() : base(Resources.Load<Sprite>(""))
    {

    }
    public override int Impact()
    {
        return 15;
    }
}
