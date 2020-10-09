using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Buswerbung : MonoBehaviour
{
    int kundenAnzahl;
    double Geld;
    public GameObject BuswerbungButton;
    public TextMeshProUGUI AusgabeText;

    public void BusAusgabe()
    {
        StartCoroutine(Execute());
        BuswerbungButton.SetActive(false);
        AusgabeText.text = "buswerbung geschaltet";
    }

    IEnumerator Execute()
    {
        yield return StartCoroutine(DatenLesen());
        BusWerbung();
        BusWerbungKosten();
        StartCoroutine(DatenSchreiben());
    }
    IEnumerator DatenLesen()
    {
        //kundenlesen php skript
        WWW www = new WWW("");
        yield return www;
        string resultGeld = www.text.Split('-')[1];
        string resultKunden = www.text.Split('-')[0];
        kundenAnzahl = Convert.ToInt32(resultKunden);
        Geld = Convert.ToDouble(resultGeld);


    }
    IEnumerator DatenSchreiben()
    {
        string x = Convert.ToString(kundenAnzahl);
        string y = Convert.ToString(Geld);
        WWWForm form = new WWWForm();
        form.AddField("kunden", x);
        form.AddField("Geldwert", y);
        
        //kundenschreiben php skript
        WWW www = new WWW("", form);
        yield return www;

    }

    public void BusWerbung()
    {
        kundenAnzahl = kundenAnzahl + 10;
    }

    public void BusWerbungKosten()
    {
        Geld = Geld - 20000;
    }
}
