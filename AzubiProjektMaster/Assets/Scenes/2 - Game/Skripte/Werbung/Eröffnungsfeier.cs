﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Eröffnungsfeier : MonoBehaviour
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

    public void ClickEröffnungIcon()
    {
        WerbungInfo.SetActive(true);
        AusgabeText.text = "eröffnungsfeier halten";

        AbwartenButton.SetActive(false);
        BuswerbungButton.SetActive(false);
        PlakateButton.SetActive(false);
        TVWerbungButton.SetActive(false);
        WerbeautoButton.SetActive(false);
        OnlinewerbungButton.SetActive(false);
        ZusatzkonditionenButton.SetActive(false);
        ZeitungswerbungButton.SetActive(false);

        EröffnungsfeierButton.SetActive(true);
    }

    public void FeierAusgabe()
    {
        StartCoroutine(Execute());
        EröffnungsfeierButton.SetActive(false);
        AusgabeText.text = "eröffnungsfeier gehalten";
    }

    IEnumerator Execute()
    {
        yield return StartCoroutine(DatenLesen());
        Feier();
        FeierKosten();
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

    public void Feier()
    {
        kundenAnzahl = kundenAnzahl + 30;
    }

    public void FeierKosten()
    {
        Geld = Geld - 2000;
    }
}
