﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entlassen : MonoBehaviour
{
    public static void Errungenschaften()
    {
        if (GlobalVariables.entlassungZaehler >= 10 & GlobalVariables.aEntlassen == 0)
        {
            GlobalVariables.achievementEntlassen = GlobalVariables.achievementEntlassen + 1;
            GlobalVariables.aEntlassen = 1;
        }

        if (GlobalVariables.entlassungZaehler >= 50 & GlobalVariables.bEntlassen == 0)
        {
            GlobalVariables.achievementEntlassen = GlobalVariables.achievementEntlassen + 1;
            GlobalVariables.bEntlassen = 1;
        }

        if (GlobalVariables.entlassungZaehler >= 100 & GlobalVariables.cEntlassen == 0)
        {
            GlobalVariables.achievementEntlassen = GlobalVariables.achievementEntlassen + 1;
            GlobalVariables.cEntlassen = 1;
        }

        if (GlobalVariables.entlassungZaehler >= 150 & GlobalVariables.dEntlassen == 0)
        {
            GlobalVariables.achievementEntlassen = GlobalVariables.achievementEntlassen + 1;
            GlobalVariables.dEntlassen = 1;
        }

        if (GlobalVariables.entlassungZaehler >= 200 & GlobalVariables.eEntlassen == 0)
        {
            GlobalVariables.achievementEntlassen = GlobalVariables.achievementEntlassen + 1;
            GlobalVariables.eEntlassen = 1;
        }
    }

    public static void Zaehler()
    {

        if (GlobalVariables.mitarbeiter >= GlobalVariables.mitarbeiterAlt)
        {
            GlobalVariables.entlassungZaehler = +1;
            GlobalVariables.mitarbeiterAlt = GlobalVariables.mitarbeiter;
        }
        else
        {
            GlobalVariables.mitarbeiterAlt = GlobalVariables.mitarbeiter;
        }
    }
}
