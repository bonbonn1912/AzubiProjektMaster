using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;


public class Kunden : MonoBehaviour
{
    public static void Errungenschaften()
    {
            if (GlobalVariables.anzahlKunden >= 100 & GlobalVariables.aKunden == 0)
            {
                GlobalVariables.achievementKunden = GlobalVariables.achievementKunden + 1;
                GlobalVariables.aKunden = 1;
            }

            if (GlobalVariables.anzahlKunden >= 1000 & GlobalVariables.bKunden == 0)
            {
                GlobalVariables.achievementKunden = GlobalVariables.achievementKunden + 1;
                GlobalVariables.bKunden = 1;
            }

            if (GlobalVariables.anzahlKunden >= 5000 & GlobalVariables.cKunden == 0)
            {
                GlobalVariables.achievementKunden = GlobalVariables.achievementKunden + 1;
                GlobalVariables.cKunden = 1;
            }

            if (GlobalVariables.anzahlKunden >= 10000 & GlobalVariables.dKunden == 0)
            {
                GlobalVariables.achievementKunden = GlobalVariables.achievementKunden + 1;
                GlobalVariables.dKunden = 1;
            }

            if (GlobalVariables.anzahlKunden >= 50000 & GlobalVariables.eKunden == 0)
            {
                GlobalVariables.achievementKunden = GlobalVariables.achievementKunden + 1;
                GlobalVariables.eKunden = 1;
            }
        }
}