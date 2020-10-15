using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Plakate : MonoBehaviour
{
    int kundenAnzahl;
    double Geld;
    public GameObject WerbungInfo;
    public GameObject AbwartenButton;
    public GameObject BuswerbungButton;
    public GameObject PlakateButton;
    public GameObject TVWerbungButton;
    public GameObject WerbeautoButton;
    public GameObject OnlinewerbungButton;
    public GameObject ZusatzkonditionenButton;
    public GameObject ZeitungswerbungButton;
    public GameObject EröffnungsfeierButton;
    public TextMeshProUGUI AusgabeText;

    public void ClickPlakateIcon()
    {
        WerbungInfo.SetActive(true);
        AusgabeText.text = "plakate aushängen";

        AbwartenButton.SetActive(false);
        BuswerbungButton.SetActive(false);
        TVWerbungButton.SetActive(false);
        WerbeautoButton.SetActive(false);
        OnlinewerbungButton.SetActive(false);
        ZusatzkonditionenButton.SetActive(false);
        ZeitungswerbungButton.SetActive(false);
        EröffnungsfeierButton.SetActive(false);
        
        PlakateButton.SetActive(true);

    }

    public void PlakateAusgabe()
    {
        StartCoroutine(Execute());
        PlakateButton.SetActive(false);
        AusgabeText.text = "Plakate ausgehängt";
    }

    IEnumerator Execute()
    {
        yield return StartCoroutine(DatenLesen());
        Plakatierung();
        PlakateKosten();
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
    public void Plakatierung()
    {
        kundenAnzahl = kundenAnzahl + 5;
    }

    public void PlakateKosten()
    {
        Geld = Geld - 500;
    }
}
