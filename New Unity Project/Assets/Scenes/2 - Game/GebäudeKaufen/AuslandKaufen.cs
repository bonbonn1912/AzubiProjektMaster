//Stand: 17.09.20
//Autor: Thorge Siemens

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System;

public class AuslandKaufen : MonoBehaviour
{
    //Variablen für Übergabe der konvertierten ausgelesenen Daten
    double geld;
    int filialenAusland;
    int Mitarbeiter;

    public void Ausland()
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
        WWW www = new WWW("http://localhost/Test/AuslandLesen.php");
        yield return www;

        string filialenDB = www.text.Split('-')[0];
        string geldDB = www.text.Split('-')[1];
        string mitarbeiterDB = www.text.Split('-')[2];

        geld = Convert.ToDouble(geldDB);
        filialenAusland = Convert.ToInt32(filialenDB);
        Mitarbeiter = Convert.ToInt32(mitarbeiterDB);
    }

    IEnumerator DatenSchreiben()
    {
        //Konvertieren und an PHP-Skript übergeben
        string geldDB = Convert.ToString(geld);
        string filialenDB = Convert.ToString(filialenAusland);
        string mitarbeiter = Convert.ToString(Mitarbeiter);

        WWWForm form = new WWWForm();
        form.AddField("Geldwert", geldDB);
        form.AddField("Auslandsfilialen", filialenDB);
        form.AddField("mitarbeiter", mitarbeiter);

        WWW www = new WWW("http://localhost/Test/AuslandSchreiben.php", form);
        yield return www;
    }


    public void FilialeKosten()
    {
        // Abfrage ob Bedingungen erfüllt sind
        if (filialenAusland != 0)
        {
            if (geld > (25000 * filialenAusland))
            {
                geld = geld - (25000 * filialenAusland);
                filialenAusland = filialenAusland + 1;
                Mitarbeiter = Mitarbeiter + 2;
            }
        }
        else
        {
            if (geld > 25000)
            {
                geld = geld - 25000;
                filialenAusland = filialenAusland + 1;
                Mitarbeiter = Mitarbeiter + 2;
            }
        }
    }
}
//Bei Bedarf noch Fehlermeldungen implementieren und ins Spiel ausgeben 