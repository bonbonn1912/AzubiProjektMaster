using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;


public class IT : MonoBehaviour
{
    int itStufe;
    int itStufeAlt;
    int achievement;
    int a, b, c, d, e;

    public void ITErrungenschaften()
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

        itStufe = Convert.ToInt32(resultAngestellte);

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

        if (itStufe > itStufeAlt)
        {

            if (itStufe >= 2 & a == 0)
            {
                achievement = achievement + 1;
            }

            if (itStufe >= 3 & b == 0)
            {
                achievement = achievement + 1;
            }

            if (itStufe >= 4 & c == 0)
            {
                achievement = achievement + 1;
            }

            if (itStufe >= 6 & d == 0)
            {
                achievement = achievement + 1;
            }

            if (itStufe >= 7 & e == 0)
            {
                achievement = achievement + 1;
            }
        }

        itStufeAlt = itStufe;
    }
}