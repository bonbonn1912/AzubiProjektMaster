using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;


public class Tutorial : MonoBehaviour
{

    public static void Errungenschaften()
    {
        if (GlobalVariables.Tutorialcheck == true & GlobalVariables.aTutorial == 0)
        {
            GlobalVariables.achievementTutorial = GlobalVariables.achievementTutorial + 1;
            GlobalVariables.aTutorial = 1;
        }
    }
}