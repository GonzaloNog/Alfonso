using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float velocidad = 10f;//velocidad de disparo
    public Vector2 direccion = Vector2.right;//direccion por defecto
    private SpriteRenderer rend;//referencia al render d ela iamgen
    public int damage;//da;o que genera la bala

    private void Start()
    {
        StartCoroutine(destroyThis());//activamos corrutina para destruir la bala luego de un tiempo
        rend = GetComponent<SpriteRenderer>();
        Disparo temp = GameManager.Instance.NewBala();//obtenemos la data de una bala d ela pila y la asignamos 
        damage = temp.Impact();
        rend.color = temp.getColor();
    }

    void Update()
    {
        // Mover el proyectil en la dirección fija cada frame
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    IEnumerator destroyThis()
    {
        yield return new WaitForSeconds(3);// espera 3 segundos antes de explotar
        Destroy(this.gameObject);
    }
}
