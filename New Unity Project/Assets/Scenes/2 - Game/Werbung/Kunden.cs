//Autor: Thorge Siemens
//Stand: 07.05.2020

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System;

public class Kunden : MonoBehaviour
{
    public Text ausgabeNamen;
 

    void Start()
    {
        ausgabeNamen.text = "Wählen Sie eine Werbeaktion. Dadurch bekommen Sie mehr Kunden. Wann immer Sie eine bestimmte Kundenanzahl erreicht haben, gibt es einen Bonus." ;
    }
}
