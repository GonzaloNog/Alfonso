using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClases : MonoBehaviour
{
    private Transporte[] trans = new Transporte[3];
    void Start()
    {
        trans[0] = new Moto(32,true,123,"red");
        trans[1] = new Coche(32, true, 123, "Mercedes");
        trans[2] = new Avion(32, true, 123, 200);

        for (int a = 0; a < trans.Length; a++)
        {
            trans[a].Arrancar();
        }
    }
}
