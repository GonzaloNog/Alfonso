using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)//verificmaos que colisiona con una bala
    {
        Bullet disp = collision.GetComponent<Bullet>();//referenciamos la clase bullet
        GameManager.Instance.uiManager.newDamageUI(disp.damage.ToString());//mostramos en la UI el da;o de la bala
        Destroy(disp.gameObject);
    }
}
