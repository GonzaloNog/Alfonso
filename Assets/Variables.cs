using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Variables : MonoBehaviour// los dos puntos reflejan que eredan de una clase en particular, esto es progresivo entre clases
{
    public int score = 0;
    private int num1 = 1;
    private int num2 = 2;
    private int num3 = 3;
    public float num4 = 4.5f;
    public float num5 = 5.5f;
    public float num6 = 6.6f;


    /*
     void Start()
    {
        
        int score = num1 + num2 + num3 ;
        Debug.Log("Score: "+score);
    }
    */


    void Start()
    {
        float score = num4 + num5 + num6;
        Debug.Log("Score: " + score);
    }
    

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
