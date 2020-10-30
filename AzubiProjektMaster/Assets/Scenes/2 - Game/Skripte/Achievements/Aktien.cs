using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aktien : MonoBehaviour
{
    public static void Errungenschaften()
    {

        if (GlobalVariables.Aktien >= 2000 & GlobalVariables.aAktien == 0)
        {
            GlobalVariables.achievementAktien = 1;
            GlobalVariables.aAktien = 1;
        }

        if (GlobalVariables.Aktien >= 5000 & GlobalVariables.aAktien == 1)
        {
            GlobalVariables.achievementAktien = 2;
            //GlobalVariables.bAktien = 1;
            GlobalVariables.aAktien = 2;
        }

        if (GlobalVariables.Aktien >= 10000 & GlobalVariables.aAktien == 2)
        {
            GlobalVariables.achievementAktien = 3;
            //GlobalVariables.cAktien = 1;
            GlobalVariables.aAktien = 3;
        }

        if (GlobalVariables.Aktien >= 10000 & GlobalVariables.aAktien == 3)
        {
            GlobalVariables.achievementAktien = 4;
            //GlobalVariables.dAktien = 1;
            GlobalVariables.aAktien = 4;
        }

        if (GlobalVariables.Aktien >= 50000 & GlobalVariables.aAktien == 4)
        {
            GlobalVariables.achievementAktien = 5;
            //GlobalVariables.eAktien = 1;
            GlobalVariables.aAktien = 5;
        }
    }
}
