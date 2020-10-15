﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;

//Anzahl der vergebenen Kredite
public class Kredite : MonoBehaviour
{
    int kredite;
    int krediteAlt;
    int achievement;
    int a, b, c, d, e;

    public void KrediteErrungenschaften()
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

        kredite = Convert.ToInt32(resultAngestellte);

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

        if (kredite > krediteAlt)
        {

            if (kredite >= 100 & a == 0)
            {
                achievement = achievement + 1;
            }

            if (kredite >= 200 & b == 0)
            {
                achievement = achievement + 1;
            }

            if (kredite >= 300 & c == 0)
            {
                achievement = achievement + 1;
            }

            if (kredite >= 400 & d == 0)
            {
                achievement = achievement + 1;
            }

            if (kredite >= 500 & e == 0)
            {
                achievement = achievement + 1;
            }
        }

        krediteAlt = kredite;
    }
}