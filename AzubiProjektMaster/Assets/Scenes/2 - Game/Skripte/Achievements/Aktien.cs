using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aktien : MonoBehaviour
{
    public static void Errungenschaften()
    {

        if (GlobalVariables.Aktien >= 20000 & GlobalVariables.aAktien == 0)
        {
            GlobalVariables.achievementAktien = GlobalVariables.achievementAktien + 1;
            GlobalVariables.aAktien = 1;
        }

        if (GlobalVariables.Aktien >= 50000 & GlobalVariables.aAktien == 1)
        {
            GlobalVariables.achievementAktien = GlobalVariables.achievementAktien + 1;
            //GlobalVariables.bAktien = 1;
            GlobalVariables.aAktien = 2;
        }

        if (GlobalVariables.Aktien >= 70000 & GlobalVariables.aAktien == 2)
        {
            GlobalVariables.achievementAktien = GlobalVariables.achievementAktien + 1;
            //GlobalVariables.cAktien = 1;
            GlobalVariables.aAktien = 3;
        }

        if (GlobalVariables.Aktien >= 90000 & GlobalVariables.aAktien == 3)
        {
            GlobalVariables.achievementAktien = GlobalVariables.achievementAktien + 1;
            //GlobalVariables.dAktien = 1;
            GlobalVariables.aAktien = 4;
        }

        if (GlobalVariables.Aktien >= 150000 & GlobalVariables.aAktien == 4)
        {
            GlobalVariables.achievementAktien = GlobalVariables.achievementAktien + 1;
            //GlobalVariables.eAktien = 1;
            GlobalVariables.aAktien = 5;
        }
    }
}
