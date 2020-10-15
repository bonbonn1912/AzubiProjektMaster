using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;


public class Tutorial : MonoBehaviour
{
    int tutorial;
    int a;
    int achievement;

    public void TutorialErrungenschaften()
    {
        StartCoroutine(Execute());
    }

    IEnumerator Execute()
    {
        yield return StartCoroutine(DatenLesen());
        Errungenschaften();
        StartCoroutine(DatenSchreiben());
    }

    IEnumerator DatenLesen()
    {
        //Auslesen und Konvertieren der Daten
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);

        WWW www = new WWW("http://localhost/Test/DwsKaufen.php", form);
        yield return www;

        string tutorialDb = www.text.Split('-')[0];
        string aDb = www.text.Split('-')[1];

        tutorial = Convert.ToInt32(tutorialDb);
        a = Convert.ToInt32(aDb);
    }

    IEnumerator DatenSchreiben()
    {
        //Konvertieren und an PHP-Skript übergeben
        string x = Convert.ToString(achievement);
        string aDb = Convert.ToString(a);
        

        WWWForm form = new WWWForm();
        form.AddField("AchievementHR", x);
        form.AddField("user", GlobalVariables.username);
        form.AddField("Wert1", aDb);

        WWW www = new WWW("http://localhost/Test/DwsSchreiben.php", form);
        yield return www;

    }

    public void Errungenschaften()
    {
        if(tutorial == 1 & a == 0)
        {
            achievement = achievement + 1;
            a = 1;
        }
    }
}