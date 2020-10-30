using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HR : MonoBehaviour
{
    public static void Errungenschaften()
    {
        if (GlobalVariables.mitarbeiter >= 10 & GlobalVariables.aHr == 0)
        {
            GlobalVariables.achievementHr = GlobalVariables.achievementHr + 1;
            GlobalVariables.aHr = 1;
        }

        if (GlobalVariables.mitarbeiter >= 50 & GlobalVariables.bHr == 0)
        {
            GlobalVariables.achievementHr = GlobalVariables.achievementHr + 1;
            GlobalVariables.bHr = 1;
        }

        if (GlobalVariables.mitarbeiter >= 100 & GlobalVariables.cHr == 0)
        {
            GlobalVariables.achievementHr = GlobalVariables.achievementHr + 1;
            GlobalVariables.cHr = 1;
        }

        if (GlobalVariables.mitarbeiter >= 500 & GlobalVariables.dHr == 0)
        {
            GlobalVariables.achievementHr = GlobalVariables.achievementHr + 1;
            GlobalVariables.dHr = 1;
        }

        if (GlobalVariables.mitarbeiter >= 1000 & GlobalVariables.eHr == 0)
        {
            GlobalVariables.achievementHr = GlobalVariables.achievementHr + 1;
            GlobalVariables.eHr = 1;
        }
    }
}
