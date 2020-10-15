using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Onlinewerbung : MonoBehaviour
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
    public GameObject BoniButton;
    public TextMeshProUGUI AusgabeText;
    
    public void ClickOnlineIcon()
    {
        WerbungInfo.SetActive(true);
        AusgabeText.text = "onlinewerbung schalten";

        AbwartenButton.SetActive(false);
        BuswerbungButton.SetActive(false);
        PlakateButton.SetActive(false);
        TVWerbungButton.SetActive(false);
        WerbeautoButton.SetActive(false);
        ZusatzkonditionenButton.SetActive(false);
        ZeitungswerbungButton.SetActive(false);
        EröffnungsfeierButton.SetActive(false);
        BoniButton.SetActive(false);

        OnlinewerbungButton.SetActive(true);
    }

    public void OnlineAusgabe()
    {
        StartCoroutine(Execute());
        OnlinewerbungButton.SetActive(false);
        AusgabeText.text = "onlinewerbung geschaltet";
    }

    IEnumerator Execute()
    {
        yield return StartCoroutine(DatenLesen());
        WerbungOnline();
        OnlineWerbungKosten();
        StartCoroutine(DatenSchreiben());
    }

    IEnumerator DatenLesen()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);

        //kundenlesen php skript
        WWW www = new WWW("", form);
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
        form.AddField("user", GlobalVariables.username);

        //kundenschreiben php skript
        WWW www = new WWW("", form);
        yield return www;
    }

    public void WerbungOnline()
    {
        //Einlesen und Wertübergabe
        kundenAnzahl = kundenAnzahl + 180;
        //Thread.Sleep(120000);   //Dauer bis Rückgabe an Datenbank 
    }

    public void OnlineWerbungKosten()
    {
        Geld = Geld - 45000;
    }
}
