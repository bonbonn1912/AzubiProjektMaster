using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;


public class Mitarbeiter_Kosten_Einkommen : MonoBehaviour
{
    int Mitarbeiter = 0;
    double Kapital = 0;
    int gehalt = 1000;
    int day = 1;
    int abzug = 0;
    int einnahmen = 0;
    int ertrag = 0;
    int IT = 1;

    public void Mitarbeitergehalt()
    {
        StartCoroutine(ExecuteKosten());
    }

    public void MitarbeiterEinkommen()
    {
        StartCoroutine(ExecuteEinnahmen());
    }
    
    //Mitarbeiter Gehalt abziehen und Werte in die Datenbank ein- & auslesen
    IEnumerator ExecuteKosten()
    {
        yield return StartCoroutine(DatenLesen());
        if(Kapital - abzug > 0 )
        {
            Gehalt();
            StartCoroutine(DatenSchreiben());

        }

        else
        {
            Debug.Log("\nNicht genug Geld - Game Over");
        }
    }

    //Datenbank ein- und Auslesen
    IEnumerator DatenLesen()
    {
        WWW www = new WWW("http://localhost/sqlconnect/MitarbeiterKostenEinkommenLesen.php");
        yield return www;
        string mitarbeiterDB = www.text.Split('-')[0];
        string geldDB = www.text.Split('-')[1];
        string tageDb = www.text.Split('-')[2];
        string ertragDB = www.text.Split('-')[3];
        Kapital = Convert.ToInt32(geldDB);
        Mitarbeiter = Convert.ToInt32(mitarbeiterDB);
        day = Convert.ToInt32(tageDb);
        ertrag = Convert.ToInt32(ertragDB);
        Debug.Log("\nMitarbeiter " + Mitarbeiter + "\nKapital " + Kapital + "\nTag " + day);
    }

    IEnumerator DatenSchreiben()
    {
        string geld = Convert.ToString(Kapital);
        WWWForm form = new WWWForm();
        form.AddField("Kapital", geld);
        WWW www = new WWW("http://localhost/sqlconnect/KapitalSchreiben.php", form);
        yield return www;
    }

    //Mitarbeitergehalt Abzug Funktion - Zentral Gebäude
    public void Gehalt()
    {

        if (day == 1)
        {
            abzug = gehalt * Mitarbeiter;
            Kapital = Kapital - abzug;
            
        }
        Debug.Log("\nAbzug " + abzug + "\nKapital " + Kapital);

    }

    //Mitarbeiter Einkommen auf das Kapital rechnen und in die Datenbank schreiben
    IEnumerator ExecuteEinnahmen()
    {
        yield return StartCoroutine(DatenLesen());
        Debug.Log("\nErtrag: " + ertrag);
        Einnahmen();
        Debug.Log("Einnahmen: " + einnahmen);        
        StartCoroutine(DatenSchreiben());
    }
    
    //Mitarbeiter Einkommen 
    public void Einnahmen()
    {
        if(day == 1)
        {
            einnahmen = 5000 * Mitarbeiter;
            if(IT >= 1)
            {
                einnahmen = einnahmen + ertrag;
            }
            Kapital = Kapital + einnahmen;
        }
         
    }

}