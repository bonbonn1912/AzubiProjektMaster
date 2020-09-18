//Stand: 17.09.20
//Autor: Thorge Siemens

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;

public class InlandKaufen : MonoBehaviour
{
    //Variablen für Übergabe der konvertierten ausgelesenen Daten
    double geld;
    int filialenInland;
    int Mitarbeiter;

    public void Inland()
    {
        StartCoroutine(Execute());
    }

    IEnumerator Execute()
    {
        yield return StartCoroutine(DatenLesen());
        FilialeKosten();
        yield return StartCoroutine(DatenSchreiben());
    }

    IEnumerator DatenLesen()
    {
        //Auslesen und Konvertieren der Daten
        WWW www = new WWW("http://localhost/Test/InlandLesen.php");
        yield return www;

        string filialenDB = www.text.Split('-')[0];
        string geldDB = www.text.Split('-')[1];
        string mitarbeiterDB = www.text.Split('-')[2];

        geld = Convert.ToDouble(geldDB);
        filialenInland = Convert.ToInt32(filialenDB);
        Mitarbeiter = Convert.ToInt32(mitarbeiterDB);
    }

    IEnumerator DatenSchreiben()
    {
        //Konvertieren und an PHP-Skript übergeben
        string geldDB = Convert.ToString(geld);
        string filialenDB = Convert.ToString(filialenInland);
        string mitarbeiterDB = Convert.ToString(Mitarbeiter);

        WWWForm form = new WWWForm();
        form.AddField("Geldwert", geldDB);
        form.AddField("Inlandsfilialen", filialenDB);
        form.AddField("mitarbeiter", mitarbeiterDB);

        WWW www = new WWW("http://localhost/Test/InlandSchreiben.php", form);
        yield return www;
    }

    public void FilialeKosten()
    {
        // Abfrage ob Bedingungen erfüllt sind
        if (filialenInland != 0)
        {
            if(geld > (25000* filialenInland)){
                geld = geld - (25000 * filialenInland);
                filialenInland = filialenInland + 1;
                Mitarbeiter = Mitarbeiter + 2; 
            }
        }
        else
        {
            if (geld > 25000)
            {
                geld = geld - 25000;
                filialenInland = filialenInland + 1;
                Mitarbeiter = Mitarbeiter + 2;
            }
        }
    }
}
//Bei Bedarf noch Fehlermeldungen implementieren und ins Spiel ausgeben 