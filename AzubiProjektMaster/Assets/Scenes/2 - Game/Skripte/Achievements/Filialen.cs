using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filialen : MonoBehaviour
{
    public static void Errungenschaften()
    {
        if (GlobalVariables.inStatus >= 10 & GlobalVariables.aFilialen == 0)
        {
            GlobalVariables.achievementFilialen = GlobalVariables.achievementFilialen + 1;
            GlobalVariables.aFilialen = 1;
        }

        if (GlobalVariables.inStatus >= 15 & GlobalVariables.aFilialen == 1)
        {
            GlobalVariables.achievementFilialen = GlobalVariables.achievementFilialen + 1;
            //GlobalVariables.bFilialen = 1;
            GlobalVariables.aFilialen = 2;
        }

        if (GlobalVariables.inStatus >= 30 & GlobalVariables.aFilialen == 2)
        {
            GlobalVariables.achievementFilialen = GlobalVariables.achievementFilialen + 1;
            //GlobalVariables.cFilialen = 1;
            GlobalVariables.aFilialen = 3;
        }

        if (GlobalVariables.inStatus >= 50 & GlobalVariables.aFilialen == 3)
        {
            GlobalVariables.achievementFilialen = GlobalVariables.achievementFilialen + 1;
            //GlobalVariables.dFilialen = 1;
            GlobalVariables.aFilialen = 4;
        }

        if (GlobalVariables.inStatus >= 75 & GlobalVariables.aFilialen ==4)
        {
            GlobalVariables.achievementFilialen = GlobalVariables.achievementFilialen + 1;
            //GlobalVariables.eFilialen = 1;
            GlobalVariables.aFilialen = 5;
        }
    }
}
