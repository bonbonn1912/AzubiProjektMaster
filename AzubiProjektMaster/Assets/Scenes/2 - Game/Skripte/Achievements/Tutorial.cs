using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public static void Errungenschaften()
    {
        if (GlobalVariables.Tutorial == 1 & GlobalVariables.aTutorial == 0)
        {
            GlobalVariables.achievementTutorial = GlobalVariables.achievementTutorial + 1;
            GlobalVariables.aTutorial = 1;
        }
    }
}
