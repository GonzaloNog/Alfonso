using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticaListas : MonoBehaviour
{
    public List<int> listInt;
    public List<string> listString;
    public List<float> listFloat;
    public List<bool> listBool;

    public bool casa = false;
    //List string
    //List bool
    //List float
    void Start()
    {
        //Listenteros();
        ListEnteros();
    }
    public void ListEnteros()
    {
        listInt = new List<int>();
        listInt.Add(10);
        listInt.Add(20);
        listInt.Add(30);
        listInt.Add(40);

        listInt.Remove(20);

        foreach (int num in listInt)
        {
            Debug.Log(num);
        }
        Debug.Log(listInt[1]);
    }
    /*
    public void ListaStrings()
    {
        listString = new List<string>();
        listString.Add("a");
        listString.Add("b");
        listString.Add("c");
        listString.Add("d");
    }

    public void ListaFloat()
    {
        listFloat = new List<float>();
        listFloat.Add(1.1F);
        listFloat.Add(1.2F);
        listFloat.Add(1.3F);
        listFloat.Add(1.4F);
    }
    public void ListaBoolean()
    {
        listBool = new List<bool>();
        listBool.Add(true);
        listBool.Add(false);
        listBool.Add(false);
    }*/
    
    
}
