using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;


public class HR : MonoBehaviour
{
    int angestellte;
    int achievement;
    int a, b, c, d, e;

    public void HrErrungenschaften()
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

        WWW www = new WWW("http://localhost/Test/AchievementHrLesen.php", form);
        yield return www;


        string angestellteDb = www.text.Split('-')[0];
        string aDb = www.text.Split('-')[1];
        string bDb = www.text.Split('-')[2];
        string cDb = www.text.Split('-')[3];
        string dDb = www.text.Split('-')[4];
        string eDb = www.text.Split('-')[5];
        string achievementDb = www.text.Split('-')[6];

        angestellte = Convert.ToInt32(angestellteDb);
        a = Convert.ToInt32(aDb);
        b = Convert.ToInt32(bDb);
        c = Convert.ToInt32(cDb);
        d = Convert.ToInt32(dDb);
        e = Convert.ToInt32(eDb);
        achievement = Convert.ToInt32(achievementDb);

    }

    IEnumerator DatenSchreiben()
    {
        //Konvertieren und an PHP-Skript übergeben
        string x = Convert.ToString(achievement);
        string aDb = Convert.ToString(a);
        string bDb = Convert.ToString(b);
        string cDb = Convert.ToString(c);
        string dDb = Convert.ToString(d);
        string eDb = Convert.ToString(e);


        WWWForm form = new WWWForm();
        form.AddField("AchievementHR", x);
        form.AddField("user", GlobalVariables.username);
        form.AddField("Wert1", aDb);
        form.AddField("Wert2", bDb);
        form.AddField("Wert3", cDb);
        form.AddField("Wert4", dDb);
        form.AddField("Wert5", eDb);

        WWW www = new WWW("http://localhost/Test/AchievementHrSchreiben.php", form);
        yield return www;

    }

    public void Errungenschaften()
    {
            if (angestellte >= 10 & a == 0)
            {
                achievement = achievement + 1;
                a = 1;
            }

            if (angestellte >= 50 & b == 0)
            {
                achievement = achievement + 1;
                b = 1;
            }

            if (angestellte >= 100 & c == 0)
            {
                achievement = achievement + 1;
                c = 1;
            }

            if (angestellte >= 500 & d == 0)
            {
                achievement = achievement + 1;
                d = 1;
            }

            if (angestellte >= 1000 & e == 0)
            {
                achievement = achievement + 1;
                e = 1;
            }
    }
}