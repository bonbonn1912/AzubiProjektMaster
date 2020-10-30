using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entlassen : MonoBehaviour
{
    public static void Errungenschaften()
    {
        Debug.Log("Tage seit Entlassung: " + GlobalVariables.entlassungZaehler);
        if (GlobalVariables.entlassungZaehler >= 10 & GlobalVariables.achievementEntlassen == 0)
        {
            GlobalVariables.achievementEntlassen = 1;
            GlobalVariables.aEntlassen = 1;
            Debug.Log("Achievement1 entlassen: " +GlobalVariables.achievementEntlassen);
        }
        Debug.Log("Achievement2 entlassen: " + GlobalVariables.achievementEntlassen);
        if (GlobalVariables.entlassungZaehler >= 50 & GlobalVariables.achievementEntlassen == 1)
        {
            GlobalVariables.achievementEntlassen = 2;
            //GlobalVariables.bEntlassen = 1;
            GlobalVariables.aEntlassen = 2;
        }

        if (GlobalVariables.entlassungZaehler >= 100 & GlobalVariables.achievementEntlassen == 2)
        {
            GlobalVariables.achievementEntlassen = 3;
            //GlobalVariables.cEntlassen = 1;
            GlobalVariables.aEntlassen = 3;
        }

        if (GlobalVariables.entlassungZaehler >= 150 & GlobalVariables.achievementEntlassen == 3)
        {
            GlobalVariables.achievementEntlassen = 4;
            //GlobalVariables.dEntlassen = 1;
            GlobalVariables.aEntlassen = 4;
        }

        if (GlobalVariables.entlassungZaehler >= 200 & GlobalVariables.achievementEntlassen == 4)
        {
            GlobalVariables.achievementEntlassen = 5;
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
            GlobalVariables.entlassungZaehler = 0;
            GlobalVariables.mitarbeiterAlt = GlobalVariables.mitarbeiter;
        }
    }
}
