using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;


public class Aktien : MonoBehaviour
{
    double aktien;
    int achievement;
    int a, b, c, d, e;

    public void AktienErrungenschaften()
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

        WWW www = new WWW("http://localhost/Test/AchievementAktienLesen.php", form); //PHP-Skript unvollständig, da nicht klar ist, wo Gewinn aus Aktien liegt
        yield return www;

        string aktienDb = www.text.Split('-')[0];
        string aDb = www.text.Split('-')[1];
        string bDb = www.text.Split('-')[2];
        string cDb = www.text.Split('-')[3];
        string dDb = www.text.Split('-')[4];
        string eDb = www.text.Split('-')[5];
        string achievementDb = www.text.Split('-')[6];

        aktien = Convert.ToInt32(aktienDb);
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
        form.AddField("AchievementShares", x);
        form.AddField("user", GlobalVariables.username);
        form.AddField("Wert1", aDb);
        form.AddField("Wert2", bDb);
        form.AddField("Wert3", cDb);
        form.AddField("Wert4", dDb);
        form.AddField("Wert5", eDb);

        WWW www = new WWW("http://localhost/Test/AchievementAktienSchreiben.php", form); //PHP-Skript unvollständig, da nicht klar ist, wo Gewinn aus Aktien liegt
        yield return www;

    }

    public void Errungenschaften()
    {

            if (aktien >= 20000 & a == 0)
            {
                achievement = achievement + 1;
                a = 1;
            }

            if (aktien >= 50000 & b == 0)
            {
                achievement = achievement + 1;
                b = 1;
            }

            if (aktien >= 70000 & c == 0)
            {
                achievement = achievement + 1;
                c = 1;
            }

            if (aktien >= 90000 & d == 0)
            {
                achievement = achievement + 1;
                d = 1;
            }

            if (aktien >= 150000 & e == 0)
            {
                achievement = achievement + 1;
                e = 1;
            }
    }
}