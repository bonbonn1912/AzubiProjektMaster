using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kunden : MonoBehaviour
{
    public static void Errungenschaften()
    {
        GlobalVariables.anzahlKunden = GlobalVariables.kundenanzahl;

        if (GlobalVariables.anzahlKunden >= 15 & GlobalVariables.aKunden == 0)
        {
            GlobalVariables.achievementKunden = 1;
            GlobalVariables.aKunden = 1;
        }

        if (GlobalVariables.anzahlKunden >= 50 & GlobalVariables.aKunden == 1)
        {
            GlobalVariables.achievementKunden = 2;
            //GlobalVariables.bKunden = 1;
            GlobalVariables.aKunden = 2;
        }

        if (GlobalVariables.anzahlKunden >= 100 & GlobalVariables.aKunden == 2)
        {
            GlobalVariables.achievementKunden = 3;
            //GlobalVariables.cKunden = 1;
            GlobalVariables.aKunden = 3;
        }

        if (GlobalVariables.anzahlKunden >= 1000 & GlobalVariables.aKunden == 3)
        {
            GlobalVariables.achievementKunden = 4;
            //GlobalVariables.dKunden = 1;
            GlobalVariables.aKunden = 4;
        }

        if (GlobalVariables.anzahlKunden >= 5000 & GlobalVariables.aKunden == 4)
        {
            GlobalVariables.achievementKunden = 5;
            //GlobalVariables.eKunden = 1;
            GlobalVariables.aKunden = 5;
        }
    }
}
