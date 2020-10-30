using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kapital : MonoBehaviour
{
    public static void Errungenschaften()
    {

        if (GlobalVariables.balance >= 200000 & GlobalVariables.aKapital == 0)
        {
            GlobalVariables.achievementKapital = GlobalVariables.achievementKapital + 1;
            GlobalVariables.aKapital = 1;
        }

        if (GlobalVariables.balance >= 600000 & GlobalVariables.aKapital == 1)
        {
            GlobalVariables.achievementKapital = GlobalVariables.achievementKapital + 1;
            //GlobalVariables.bKapital = 1;
            GlobalVariables.aKapital = 2;
        }

        if (GlobalVariables.balance >= 1000000 & GlobalVariables.aKapital == 2)
        {
            GlobalVariables.achievementKapital = GlobalVariables.achievementKapital + 1;
            //GlobalVariables.cKapital = 1;
            GlobalVariables.aKapital = 3;
        }

        if (GlobalVariables.balance >= 1500000 & GlobalVariables.aKapital == 3)
        {
            GlobalVariables.achievementKapital = GlobalVariables.achievementKapital + 1;
            //GlobalVariables.dKapital = 1;
            GlobalVariables.aKapital = 4;
        }

        if (GlobalVariables.balance >= 2000000 & GlobalVariables.aKapital == 4)
        {
            GlobalVariables.achievementKapital = GlobalVariables.achievementKapital + 1;
            //GlobalVariables.eKapital = 1;
            GlobalVariables.aKapital = 5;
        }
    }
}
