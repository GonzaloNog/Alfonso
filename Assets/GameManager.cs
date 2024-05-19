using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Stack<Disparo> disparoList = new Stack<Disparo>(); // pila de balas
    public UIManager uiManager; // referencia para usar el UI manager
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    public void Start()
    {
        NewCargador();
    }
    public void newDisparoType(int type)//generamos una bala nueva de forma random
    {
        Disparo dis;
        switch (type)
        {
            case 1:
                dis = new DisparoFuego();
                disparoList.Push(dis);
                break;
            case 2:
                dis = new DisparoHielo();
                disparoList.Push(dis);
                break;
            case 3:
                dis = new DisparoTierra();
                disparoList.Push(dis);
                break;
        }
    }
    public void NewCargador()// creamos 30 balas random y la ponemos en la pila
    {
        for(int a = 0; a < 30; a++)
        {
            newDisparoType(Random.Range(1, 4));
        }
    }
    public Disparo NewBala()// sacamos una bala de la pila
    {
        return disparoList.Pop();
    }
}
