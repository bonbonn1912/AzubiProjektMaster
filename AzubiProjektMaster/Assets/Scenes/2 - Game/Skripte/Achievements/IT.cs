using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IT : MonoBehaviour
{
    public static void Errungenschaften()
    {

        if (GlobalVariables.itStatus >= 2 & GlobalVariables.aIt == 0)
        {
            GlobalVariables.achievementIt = GlobalVariables.achievementIt + 1;
            GlobalVariables.aIt = 1;
        }

        if (GlobalVariables.itStatus >= 3 & GlobalVariables.bIt == 0)
        {
            GlobalVariables.achievementIt = GlobalVariables.achievementIt + 1;
            GlobalVariables.bIt = 1;
        }

        if (GlobalVariables.itStatus >= 4 & GlobalVariables.cIt == 0)
        {
            GlobalVariables.achievementIt = GlobalVariables.achievementIt + 1;
            GlobalVariables.cIt = 1;
        }

        if (GlobalVariables.itStatus >= 6 & GlobalVariables.dIt == 0)
        {
            GlobalVariables.achievementIt = GlobalVariables.achievementIt + 1;
            GlobalVariables.dIt = 1;
        }

        if (GlobalVariables.itStatus >= 7 & GlobalVariables.eIt == 0)
        {
            GlobalVariables.achievementIt = GlobalVariables.achievementIt + 1;
            GlobalVariables.eIt = 1;
        }
    }
}
