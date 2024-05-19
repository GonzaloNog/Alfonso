using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textDamage;

    private void Start()
    {
        textDamage.text = "";
    }
    public void newDamageUI(string damage)
    {
        textDamage.text = damage;//muestro el texto del da;o en la UI
    }
}
