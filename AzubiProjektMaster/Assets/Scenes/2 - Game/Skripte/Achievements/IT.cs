using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IT : MonoBehaviour
{
    public static void Errungenschaften()
    {

        if (GlobalVariables.itStatus >= 2 & GlobalVariables.aIt == 0)
        {
            GlobalVariables.achievementIt = 1;
            GlobalVariables.aIt = 1;
        }

        if (GlobalVariables.itStatus >= 3 & GlobalVariables.aIt == 1)
        {
            GlobalVariables.achievementIt = 2;
            //GlobalVariables.bIt = 1;
            GlobalVariables.aIt = 2;
        }

        if (GlobalVariables.itStatus >= 4 & GlobalVariables.aIt == 2)
        {
            GlobalVariables.achievementIt = 3;
            //GlobalVariables.cIt = 1;
            GlobalVariables.aIt = 3;
        }

        if (GlobalVariables.itStatus >= 6 & GlobalVariables.aIt == 3)
        {
            GlobalVariables.achievementIt = 4;
            //GlobalVariables.dIt = 1;
            GlobalVariables.aIt = 4;
        }

        if (GlobalVariables.itStatus >= 7 & GlobalVariables.aIt == 4)
        {
            GlobalVariables.achievementIt = 5;
            //GlobalVariables.eIt = 1;
            GlobalVariables.aIt = 5;
        }
    }
}
