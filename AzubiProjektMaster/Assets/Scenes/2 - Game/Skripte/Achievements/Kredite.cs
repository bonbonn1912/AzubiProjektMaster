using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kredite : MonoBehaviour
{
    public static void Errungenschaften()
    {

        if (GlobalVariables.anzahlKredite >= 100 & GlobalVariables.aKredite == 0)
        {
            GlobalVariables.achievementKredite = GlobalVariables.achievementKredite + 1;
            GlobalVariables.aKredite = 1;
        }

        if (GlobalVariables.anzahlKredite >= 200 & GlobalVariables.aKredite == 1)
        {
            GlobalVariables.achievementKredite = GlobalVariables.achievementKredite + 1;
            //GlobalVariables.bKredite = 1;
            GlobalVariables.aKredite = 2;
        }

        if (GlobalVariables.anzahlKredite >= 300 & GlobalVariables.aKredite == 2)
        {
            GlobalVariables.achievementKredite = GlobalVariables.achievementKredite + 1;
            //GlobalVariables.cKredite = 1;
            GlobalVariables.aKredite = 3;
        }

        if (GlobalVariables.anzahlKredite >= 400 & GlobalVariables.aKredite == 3)
        {
            GlobalVariables.achievementKredite = GlobalVariables.achievementKredite + 1;
            //GlobalVariables.dKredite = 1;
            GlobalVariables.aKredite = 4;
        }

        if (GlobalVariables.anzahlKredite >= 500 & GlobalVariables.aKredite == 4)
        {
            GlobalVariables.achievementKredite = GlobalVariables.achievementKredite + 1;
            //GlobalVariables.eKredite = 1;
            GlobalVariables.aKredite = 5;
        }
    }
}
