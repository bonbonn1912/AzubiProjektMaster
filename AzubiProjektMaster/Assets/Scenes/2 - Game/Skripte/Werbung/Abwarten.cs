using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Abwarten : MonoBehaviour
{
    int kundenAnzahl;
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
    
    public void ClickAbwartenIcon()
    {
        WerbungInfo.SetActive(true);
        AusgabeText.text = "abwarten";

        BuswerbungButton.SetActive(false);
        PlakateButton.SetActive(false);
        TVWerbungButton.SetActive(false);
        WerbeautoButton.SetActive(false);
        OnlinewerbungButton.SetActive(false);
        ZusatzkonditionenButton.SetActive(false);
        ZeitungswerbungButton.SetActive(false);
        EröffnungsfeierButton.SetActive(false);
        
        AbwartenButton.SetActive(true);
    }


    IEnumerator Execute()
    {
        yield return StartCoroutine(DatenLesen());
        Warten();
        StartCoroutine(DatenSchreiben());
    }

    IEnumerator DatenLesen()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);
        
        //kundenlesen php skript
        WWW www = new WWW("", form);
        yield return www;
        string resultKunden = www.text.Split('-')[0];
        kundenAnzahl = Convert.ToInt32(resultKunden);
    }

    IEnumerator DatenSchreiben()
    {
        string x = Convert.ToString(kundenAnzahl);
        WWWForm form = new WWWForm();
        form.AddField("kunden", x);
        form.AddField("user", GlobalVariables.username);

        //kundenschreiben php skript
        WWW www = new WWW("", form);
        yield return www;
    }

    public void Warten()
    {
        kundenAnzahl = kundenAnzahl + 10;
    }
}
