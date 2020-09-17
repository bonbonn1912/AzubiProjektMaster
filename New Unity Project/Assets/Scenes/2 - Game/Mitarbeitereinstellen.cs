using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;

public class Mitarbeitereinstellen : MonoBehaviour
{
    public Text textfeld;
    public int Mitarbeiter = 0;
    public int Kosten = 1000;
    int Kapital = 50000;

    public void MitarbeiterEinstellen()
    {
        StartCoroutine(Execute());
    }

    IEnumerator Execute()
    {
        yield return StartCoroutine(DatenLesen());
        Einstellen();
        StartCoroutine(DatenSchreiben());
    }

    IEnumerator DatenLesen()
    {
        WWW www = new WWW("http://localhost/sqlconnect/MitarbeiterEinstellenLesen.php");
        yield return www;
        string mitarbeiterDB = www.text.Split('-')[0];
        string mitarbeiterKosten = www.text.Split('-')[1];
        string kapitalDB = www.text.Split('-')[2];
        Mitarbeiter = Convert.ToInt32(mitarbeiterDB);
        Kosten = Convert.ToInt32(mitarbeiterKosten);
        Kapital = Convert.ToInt32(kapitalDB);
    }

    IEnumerator DatenSchreiben()
    {
        string mitarbeiter = Convert.ToString(Mitarbeiter);
        string kosten = Convert.ToString(Kosten);
        string kapital = Convert.ToString(Kapital);
        WWWForm form = new WWWForm();
        form.AddField("Mitarbeiter", mitarbeiter);
        form.AddField("Kosten", kosten);
        form.AddField("Kapital", kapital);
        WWW www = new WWW("http://localhost/sqlconnect/MitarbeiterEinstellenSchreiben.php", form);
        yield return www;
    }

    public void Einstellen()
    {
        if (Kapital > Kosten)
        {
            Mitarbeiter++;
            Kapital = Kapital - Kosten;
            Kosten = Kosten + 1000;
            textfeld.text = Mitarbeiter.ToString();
            Debug.Log("\nMitarbeiteranzahl: " + Mitarbeiter +"\n"+ "Kapital: " + Kapital);
        }
        else
        {
            Debug.Log("\nSorry, nicht genug Geld");
        }
    }
}