using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Variables : MonoBehaviour// los dos puntos reflejan que eredan de una clase en particular, esto es progresivo entre clases
{
    public int score = 0;

    void Start()
    {
        Debug.Log("Score: "+score);
    }
    /*
    void Start()
    {

    }
    */

    //Ejer1: poner 3 variables privadas de tipo entero con numeros, sumarlos en score y mostrar el resultado
    //Ejer2: poner 3 variables publicas de tipo float, modificar sus valores desde el inspector y sumarlos en score2(float)


    //Set y get
    /*
    public void setScore(int _score)
    {
        score = _score;
    }
    public int getScore() 
    {
        return score; 
    }*/
    
}
