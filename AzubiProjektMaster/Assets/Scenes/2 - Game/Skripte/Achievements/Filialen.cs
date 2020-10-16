using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;


public class Filialen : MonoBehaviour
{
    int filialen;
    int filialenAlt;
    int achievement;
    int a, b, c, d, e;

    public void FilialenErrungenschaften()
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

        string resultAngestellte = www.text.Split('-')[0];

        filialen = Convert.ToInt32(resultAngestellte);

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
            if (filialen >= 10 & a == 0)
            {
                achievement = achievement + 1;
            }

            if (filialen >= 15 & b == 0)
            {
                achievement = achievement + 1;
            }

            if (filialen >= 30 & c == 0)
            {
                achievement = achievement + 1;
            }

            if (filialen >= 50 & d == 0)
            {
                achievement = achievement + 1;
            }

            if (filialen >= 75 & e == 0)
            {
                achievement = achievement + 1;
            }
        }
}