﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;


public class Entlassen : MonoBehaviour
{
   

    public static void Errungenschaften()
    {
            if (GlobalVariables.Tage >= 10 & GlobalVariables.aEntlassen == 0)
            {
                GlobalVariables.achievementEntlassen = GlobalVariables.achievementEntlassen + 1;
                GlobalVariables.aEntlassen = 1;
            }

            if (GlobalVariables.Tage >= 50 & GlobalVariables.bEntlassen == 0)
            {
                GlobalVariables.achievementEntlassen = GlobalVariables.achievementEntlassen + 1;
                GlobalVariables.bEntlassen = 1;
            }

            if (GlobalVariables.Tage >= 100 & GlobalVariables.cEntlassen == 0)
            {
                GlobalVariables.achievementEntlassen = GlobalVariables.achievementEntlassen + 1;
                GlobalVariables.cEntlassen = 1;
            }

            if (GlobalVariables.Tage >= 150 & GlobalVariables.dEntlassen == 0)
            {
                GlobalVariables.achievementEntlassen = GlobalVariables.achievementEntlassen + 1;
                GlobalVariables.dEntlassen = 1;
            }

            if (GlobalVariables.Tage >= 200 & GlobalVariables.eEntlassen == 0)
            {
                GlobalVariables.achievementEntlassen = GlobalVariables.achievementEntlassen + 1;
                GlobalVariables.eEntlassen = 1;
            }
        }
}