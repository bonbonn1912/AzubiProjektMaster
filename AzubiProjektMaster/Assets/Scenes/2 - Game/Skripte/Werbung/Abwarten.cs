﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Abwarten : MonoBehaviour
{
    int kundenAnzahl;
    public GameObject AbwartenButton;
    public TextMeshProUGUI AusgabeText;
    
    public void AbwartenAusgabe()
    {
        StartCoroutine(Execute());
        AbwartenButton.SetActive(false);
        AusgabeText.text = "abgewartet";
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
