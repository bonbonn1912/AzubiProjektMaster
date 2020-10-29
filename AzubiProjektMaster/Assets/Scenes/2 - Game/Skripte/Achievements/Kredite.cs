using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;

//Anzahl der vergebenen Kredite
public class Kredite : MonoBehaviour
{
    public static void Errungenschaften()
    {

        if (GlobalVariables.anzahlKredite >= 100 & GlobalVariables.aKredite == 0)
        {
            GlobalVariables.achievementKredite = GlobalVariables.achievementKredite + 1;
            GlobalVariables.aKredite = 1;
        }

        if (GlobalVariables.anzahlKredite >= 200 & GlobalVariables.bKredite == 0)
        {
            GlobalVariables.achievementKredite = GlobalVariables.achievementKredite + 1;
            GlobalVariables.bKredite = 1;
        }

        if (GlobalVariables.anzahlKredite >= 300 & GlobalVariables.cKredite == 0)
        {
            GlobalVariables.achievementKredite = GlobalVariables.achievementKredite + 1;
            GlobalVariables.cKredite = 1;
        }

        if (GlobalVariables.anzahlKredite >= 400 & GlobalVariables.dKredite == 0)
        {
            GlobalVariables.achievementKredite = GlobalVariables.achievementKredite + 1;
            GlobalVariables.dKredite = 1;
        }

        if (GlobalVariables.anzahlKredite >= 500 & GlobalVariables.eKredite == 0)
        {
            GlobalVariables.achievementKredite = GlobalVariables.achievementKredite + 1;
            GlobalVariables.eKredite = 1;
        }
    }
}