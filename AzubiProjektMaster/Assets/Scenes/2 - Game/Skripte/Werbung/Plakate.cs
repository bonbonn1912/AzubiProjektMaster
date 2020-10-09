using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Plakate : MonoBehaviour
{
    int kundenAnzahl;
    double Geld;
    public GameObject PlakateButton;
    public TextMeshProUGUI AusgabeText;


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
