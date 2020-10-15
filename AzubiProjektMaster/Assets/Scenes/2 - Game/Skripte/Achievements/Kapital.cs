using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;


public class Kapital : MonoBehaviour
{
    int kapital;
    int kapitalAlt;
    int achievement;
    int a, b, c, d, e;

    public void KapitalErrungenschaften()
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
        string aDb = www.text.Split('-')[1];
        string bDb = www.text.Split('-')[2];
        string cDb = www.text.Split('-')[3];
        string dDb = www.text.Split('-')[4];
        string eDb = www.text.Split('-')[5];

        kapital = Convert.ToInt32(resultAngestellte);
        a = Convert.ToInt32(aDb);
        b = Convert.ToInt32(bDb);
        c = Convert.ToInt32(cDb);
        d = Convert.ToInt32(dDb);
        e = Convert.ToInt32(eDb);

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

            if (kapital >= 200000)
            {
                achievement = achievement + 1;
                a = 1;
            }

            if (kapital >= 600000 & b == 0)
            {
                achievement = achievement + 1;
                b = 1;
            }

            if (kapital >= 1000000 & c == 0)
            {
                achievement = achievement + 1;
                c = 1;
            }

            if (kapital >= 1500000 & d == 0)
            {
                achievement = achievement + 1;
                d = 1;
            }

            if (kapital >= 2000000 & e == 0)
            {
                achievement = achievement + 1;
                e = 1;
            }
        }
}