using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;


public class Entlassen : MonoBehaviour
{
    int tage;
    int tageAlt;
    int achievement;
    int a, b, c, d, e;

    public void EntlassenErrungenschaften()
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

        string resultTage = www.text.Split('-')[0];

        tage = Convert.ToInt32(resultTage);

    }

    IEnumerator DatenSchreiben()
    {
        //Konvertieren und an PHP-Skript übergeben
        string x = Convert.ToString(achievement);


        WWWForm form = new WWWForm();
        form.AddField("AchievementHR", x);
        form.AddField("user", GlobalVariables.username);

        WWW www = new WWW("http://localhost/Test/DwsSchreiben.php", form);
        yield return www;

    }

    public void Errungenschaften()
    {

        if (tage > tageAlt)
        {

            if (tage >= 10 & a == 0)
            {
                achievement = achievement + 1;
            }

            if (tage >= 20 & b == 0)
            {
                achievement = achievement + 1;
            }

            if (tage >= 30 & c == 0)
            {
                achievement = achievement + 1;
            }

            if (tage >= 40 & d == 0)
            {
                achievement = achievement + 1;
            }

            if (tage >= 50 & e == 0)
            {
                achievement = achievement + 1;
            }
        }

        tageAlt = tage;
    }
}