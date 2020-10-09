using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Zusatzkonditionen : MonoBehaviour
{
    int kundenAnzahl;
    double Geld;
    public GameObject ZusatzkonditionenButton;
    public TextMeshProUGUI AusgabeText;

    public void ZusatzAusgabe()
    {
        StartCoroutine(Execute());
        ZusatzkonditionenButton.SetActive(false);
        AusgabeText.text = "zusatzkonditionen freigegeben";
    }

    IEnumerator Execute()
    {
        yield return StartCoroutine(DatenLesen());
        Zusatz();
        ZusatzKosten();
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

    public void Zusatz()
    {
        kundenAnzahl = kundenAnzahl + 5;    
    }

    public void ZusatzKosten()
    {
        Geld = Geld - 500;
        //Rückgabe Geld an Datenbank
    }
}
