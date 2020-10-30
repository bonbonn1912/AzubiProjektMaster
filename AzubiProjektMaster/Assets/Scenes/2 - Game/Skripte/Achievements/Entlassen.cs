using System.Collections;
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

        if (GlobalVariables.entlassungZaehler >= 50 & GlobalVariables.aEntlassen == 1)
        {
            GlobalVariables.achievementEntlassen = GlobalVariables.achievementEntlassen + 1;
            //GlobalVariables.bEntlassen = 1;
            GlobalVariables.aEntlassen = 2;
        }

        if (GlobalVariables.entlassungZaehler >= 100 & GlobalVariables.aEntlassen == 2)
        {
            GlobalVariables.achievementEntlassen = GlobalVariables.achievementEntlassen + 1;
            //GlobalVariables.cEntlassen = 1;
            GlobalVariables.aEntlassen = 3;
        }

        if (GlobalVariables.entlassungZaehler >= 150 & GlobalVariables.aEntlassen ==3)
        {
            GlobalVariables.achievementEntlassen = GlobalVariables.achievementEntlassen + 1;
            //GlobalVariables.dEntlassen = 1;
            GlobalVariables.aEntlassen = 4;
        }

        if (GlobalVariables.entlassungZaehler >= 200 & GlobalVariables.aEntlassen == 4)
        {
            GlobalVariables.achievementEntlassen = GlobalVariables.achievementEntlassen + 1;
            //GlobalVariables.eEntlassen = 1;
            GlobalVariables.aEntlassen = 5;
        }
    }

    public static void Zaehler()
    {

        if (GlobalVariables.mitarbeiter >= GlobalVariables.mitarbeiterAlt)
        {
            GlobalVariables.entlassungZaehler = GlobalVariables.entlassungZaehler + 1;
            GlobalVariables.mitarbeiterAlt = GlobalVariables.mitarbeiter;
        }
        else
        {
            GlobalVariables.mitarbeiterAlt = GlobalVariables.mitarbeiter;
        }
    }
}
