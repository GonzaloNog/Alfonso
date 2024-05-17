using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float velocidad = 10f;
    public Vector2 direccion = Vector2.right;
    private SpriteRenderer rend;

    private void Start()
    {
        StartCoroutine(destroyThis());
        rend = GetComponent<SpriteRenderer>();
        rend.sprite = GameManager.Instance.disparo.getSprite();
    }

    void Update()
    {
        // Mover el proyectil en la dirección fija cada frame
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    IEnumerator destroyThis()
    {
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);
    }
}
