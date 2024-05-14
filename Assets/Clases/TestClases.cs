using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClases : MonoBehaviour
{
    private Transporte[] trans = new Transporte[2];
    void Start()
    {
        trans[0] = new Moto(32,true,123,"red");
        trans[1] = new Coche(32, true, 123, "red");

        for (int a = 0; a < trans.Length; a++)
        {
            trans[a].Arrancar();
        }
    }
}
