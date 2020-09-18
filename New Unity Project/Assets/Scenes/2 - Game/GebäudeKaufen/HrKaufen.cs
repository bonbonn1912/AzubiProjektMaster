﻿//Stand: 17.09.20
//Autor: Thorge Siemens

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;

public class HrKaufen : MonoBehaviour
{
    //Variablen für Übergabe der konvertierten ausgelesenen Daten
    int HRWert;
    double Geld;
    int Filialen;

    public void HRKaufen()
    {

        StartCoroutine(Execute());

    }

    IEnumerator Execute()
    {
        Debug.Log("Execute Methode bevor Coroutine gestartet wird");
        yield return StartCoroutine(DatenLesen());
        Debug.Log("Nach der Coroutine");
        Kaufen();
        StartCoroutine(DatenSchreiben());
    }
    IEnumerator DatenLesen()
    {
        //Auslesen und Konvertieren der Daten
        WWW www = new WWW("http://localhost/Test/HrLesen.php");
        yield return www;

        string resultHR = www.text.Split('-')[0];
        string resultGeld = www.text.Split('-')[1];
        string resultFilialen = www.text.Split('-')[2];

        HRWert = Convert.ToInt32(resultHR);
        Geld = Convert.ToDouble(resultGeld);
        Filialen = Convert.ToInt32(resultFilialen);


    }
    IEnumerator DatenSchreiben()
    {
        //Konvertieren und an PHP-Skript übergeben
        string x = Convert.ToString(HRWert);
        string y = Convert.ToString(Geld);

        WWWForm form = new WWWForm();
        form.AddField("HrWert", x);
        form.AddField("Geldwert", y);

        WWW www = new WWW("http://localhost/Test/HrKaufen.php", form);
        yield return www;

    }

    public void Kaufen()
    {
        // Abfrage ob Bedingungen erfüllt sind
        if (HRWert == 0)
        {
            if (Filialen >= 4)
            {
                if (Geld > 350000)
                {
                    Geld = Geld - 350000;
                    HRWert = 1;
                }
                else
                {
                    FehlerDrei();
                }
            }
            else
            {
                FehlerZwei();
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
        Debug.Log("Du hast dieses Gebäude bereits gekauft");
    }
    public void FehlerZwei()
    {
        Debug.Log("Du hast nicht genug Filialen");
    }
    
    public void FehlerDrei()
    {
        Debug.Log("Du hast nicht genug Geld");
    }
}
