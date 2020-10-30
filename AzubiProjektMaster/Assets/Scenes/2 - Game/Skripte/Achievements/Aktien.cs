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

        if (GlobalVariables.Aktien >= 50000 & GlobalVariables.bAktien == 0)
        {
            GlobalVariables.achievementAktien = GlobalVariables.achievementAktien + 1;
            GlobalVariables.bAktien = 1;
        }

        if (GlobalVariables.Aktien >= 70000 & GlobalVariables.cAktien == 0)
        {
            GlobalVariables.achievementAktien = GlobalVariables.achievementAktien + 1;
            GlobalVariables.cAktien = 1;
        }

        if (GlobalVariables.Aktien >= 90000 & GlobalVariables.dAktien == 0)
        {
            GlobalVariables.achievementAktien = GlobalVariables.achievementAktien + 1;
            GlobalVariables.dAktien = 1;
        }

        if (GlobalVariables.Aktien >= 150000 & GlobalVariables.eAktien == 0)
        {
            GlobalVariables.achievementAktien = GlobalVariables.achievementAktien + 1;
            GlobalVariables.eAktien = 1;
        }
    }
}
