using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject prefad;
    public float velocidad = 5f;
    private Vector2 direccionMirada = Vector2.right;

    private void Start()
    {
        GameManager.Instance.newDisparoType("fire");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Disparar();
        }
        float movimientoHorizontal = Input.GetAxis("Horizontal");

        if (movimientoHorizontal != 0)
        {
            // Actualiza la dirección en la que mira el jugador
            direccionMirada = new Vector2(movimientoHorizontal, 0).normalized;

            // Mueve al jugador
            transform.Translate(new Vector2(movimientoHorizontal, 0) * velocidad * Time.deltaTime);

            // Gira el sprite del jugador según la dirección en la que se mueve
            Vector3 escala = transform.localScale;
            escala.x = movimientoHorizontal > 0 ? 1 : -1;
            transform.localScale = escala;
        }
    }
    public Vector2 ObtenerDireccionMirada()
    {
        return direccionMirada;
    }
    public void Disparar()
    {
        Vector2 direccionDisparo = ObtenerDireccionMirada();
        GameObject proyectil = Instantiate(prefad, transform.position, Quaternion.identity);
        Bullet scriptProyectil = proyectil.GetComponent<Bullet>();
        scriptProyectil.direccion = direccionDisparo;
    }
}
