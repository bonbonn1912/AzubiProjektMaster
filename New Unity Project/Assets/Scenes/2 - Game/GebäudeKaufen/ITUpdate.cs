//Stand: 17.09.20
//Autor: Thorge Siemens

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;

public class ITUpdate : MonoBehaviour
{
    //Variablen für Übergabe der konvertierten ausgelesenen Daten
    int ITWert;
    double Geld;

    public void BoolÜberschreiben()
    {
        StartCoroutine(Execute());
    }

    IEnumerator Execute()
    {
        yield return StartCoroutine(DatenLesen());
        Kaufen();
        StartCoroutine(DatenSchreiben());
    }

    IEnumerator DatenLesen()
    {
        //Auslesen und Konvertieren der Daten
        WWW www = new WWW("http://localhost/Test/ItStufe.php");
        yield return www;

        string stufeIT = www.text.Split('-')[0];
        string geldDB= www.text.Split('-')[1];

        ITWert = Convert.ToInt32(stufeIT);
        Geld = Convert.ToDouble(geldDB);
    }

    IEnumerator DatenSchreiben()
    {
        //Konvertieren und an PHP-Skript übergeben
        string x = Convert.ToString(ITWert);
        string y = Convert.ToString(Geld);

        WWWForm form = new WWWForm();
        form.AddField("ItWert", x);
        form.AddField("Geldwert", y);

        WWW www = new WWW("http://localhost/Test/ItUpdate.php", form);
        yield return www;

    }

    public void Kaufen()
    {
        //Abfrage ob Bedingungen erfüllt sind
        if (ITWert >= 1)
        {
            if (Geld > 300000)
            {
                Geld = Geld - 300000;
                ITWert = ITWert + 1;
            }
            else
            {
                FehlerDrei();
            }
        }
        else
        {
            Fehler();
        }

    }

    //Fehlermeldungen müssen evtl noch angepasst werden bzgl Ausgabe im Spiel selber
    public void Fehler()
    {
        Debug.Log("Du hast nicht genug Geld");
    }

    public void FehlerDrei()
    {
        Debug.Log("Du hast nicht genug Geld");
    }
}