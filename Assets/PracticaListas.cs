using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticaListas : MonoBehaviour
{
    public List<int> listInt;
    public List<string> listString;

    //List string
    //List bool
    //List float
    void Start()
    {
        //Listenteros();
        ListaStrings();
    }
    public void Listenteros()
    {
        listInt = new List<int>();
        listInt.Add(10);
        listInt.Add(20);
        listInt.Add(30);
        listInt.Add(40);

        foreach (int num in listInt)
        {
            Debug.Log(num);
        }
        Debug.Log(listInt[1]);
    }
    public void ListaStrings()
    {

    }
}
