using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;


public class Kapital : MonoBehaviour
{

    public static void Errungenschaften()
    {

            if (GlobalVariables.balance >= 200000 & GlobalVariables.aKapital == 0)
            {
                GlobalVariables.achievementKapital = GlobalVariables.achievementKapital + 1;
                GlobalVariables.aKapital = 1;
            }

            if (GlobalVariables.balance >= 600000 & GlobalVariables.bKapital == 0)
            {
                GlobalVariables.achievementKapital = GlobalVariables.achievementKapital + 1;
                GlobalVariables.bKapital = 1;
            }

            if (GlobalVariables.balance >= 1000000 & GlobalVariables.cKapital == 0)
            {
                GlobalVariables.achievementKapital = GlobalVariables.achievementKapital + 1;
                GlobalVariables.cKapital = 1;
            }

            if (GlobalVariables.balance >= 1500000 & GlobalVariables.dKapital == 0)
            {
                GlobalVariables.achievementKapital = GlobalVariables.achievementKapital + 1;
                GlobalVariables.dKapital = 1;
            }

            if (GlobalVariables.balance >= 2000000 & GlobalVariables.eKapital == 0)
            {
                GlobalVariables.achievementKapital = GlobalVariables.achievementKapital + 1;
                GlobalVariables.eKapital = 1;
            }
        }
}