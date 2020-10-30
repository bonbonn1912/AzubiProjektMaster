using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filialen : MonoBehaviour
{
    public static void Errungenschaften()
    {
        if (GlobalVariables.inStatus >= 5 & GlobalVariables.aFilialen == 0)
        {
            GlobalVariables.achievementFilialen = 1;
            GlobalVariables.aFilialen = 1;
        }

        if (GlobalVariables.inStatus >= 10 & GlobalVariables.aFilialen == 1)
        {
            GlobalVariables.achievementFilialen = 2;
            //GlobalVariables.bFilialen = 1;
            GlobalVariables.aFilialen = 2;
        }

        if (GlobalVariables.inStatus >= 15 & GlobalVariables.aFilialen == 2)
        {
            GlobalVariables.achievementFilialen = 3;
            //GlobalVariables.cFilialen = 1;
            GlobalVariables.aFilialen = 3;
        }

        if (GlobalVariables.inStatus >= 20 & GlobalVariables.aFilialen == 3)
        {
            GlobalVariables.achievementFilialen = 4;
            //GlobalVariables.dFilialen = 1;
            GlobalVariables.aFilialen = 4;
        }

        if (GlobalVariables.inStatus >= 25 & GlobalVariables.aFilialen ==4)
        {
            GlobalVariables.achievementFilialen = 5;
            //GlobalVariables.eFilialen = 1;
            GlobalVariables.aFilialen = 5;
        }
    }
}
