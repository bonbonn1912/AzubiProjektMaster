//Stand: 17.09.20
//Autor: Thorge Siemens

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;

public class ITKaufen : MonoBehaviour
{
    //Variablen für Übergabe der konvertierten ausgelesenen Daten
    int ItWert;
    double Geld;
    int Filialen;

    public void ItKaufen()
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
        WWW www = new WWW("http://localhost/Test/ITkaufen.php");
        yield return www;

        string resultGeld = www.text.Split('-')[1];
        string resultIT = www.text.Split('-')[0];
        string resultFilialen = www.text.Split('-')[2];

        ItWert = Convert.ToInt32(resultIT);
        Geld = Convert.ToDouble(resultGeld);
        Filialen = Convert.ToInt32(resultFilialen);

    }
    IEnumerator DatenSchreiben()
    {
        //Konvertieren und an PHP-Skript übergeben
        string x = Convert.ToString(ItWert);
        string y = Convert.ToString(Geld);

        WWWForm form = new WWWForm();
        form.AddField("ItWert", x);
        Debug.Log("ITWert =" + x);
        form.AddField("Geldwert", y);

        WWW www = new WWW("http://localhost/Test/ITSchreiben.php", form);
        yield return www;

    }
  
    public void Kaufen()
    {
        // Abfrage ob Bedingungen erfüllt sind
        if (ItWert == 0)
        {
            Debug.Log("Stage 1");
            if (Filialen >= 2)
            {
                if (Geld > 300000)
                {
                    Debug.Log("Stage 2");
                    Geld = Geld - 300000;
                    ItWert = 1;
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
        Debug.Log ("Du hast nicht genug Filialen");
    }

    public void FehlerDrei()
    {
        Debug.Log("Du hast nicht genug Geld");
    }
}