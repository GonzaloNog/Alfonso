using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject prefad;
    public float velocidad = 5f;
    private Vector2 direccionMirada = Vector2.right;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//tecla space para disparar
        {
            Disparar();
        }
        float movimientoHorizontal = Input.GetAxis("Horizontal");//verificamos la entrada de teclado horizontal

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
    public Vector2 ObtenerDireccionMirada()//lo usamos para saber en que direccion miramos para los nuevos disparos
    {
        return direccionMirada;
    }
    public void Disparar()
    {
        if(GameManager.Instance.disparoList.Count != 0)//verificamos que nos quedan balas disponibles
        {
            Vector2 direccionDisparo = ObtenerDireccionMirada();//obtenemos direccion de disparo
            GameObject proyectil = Instantiate(prefad, transform.position, Quaternion.identity);//creamos nueva bala
            Bullet scriptProyectil = proyectil.GetComponent<Bullet>();//entramos al codigo de la bala
            scriptProyectil.direccion = direccionDisparo;//asignamos al direccion
        }

    }
}
