using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Werbeauto : MonoBehaviour
{
    int kundenAnzahl;
    double Geld;
    public GameObject WerbeautoButton;
    public TextMeshProUGUI AusgabeText;

    public void AutoAusgabe()
    {
        StartCoroutine(Execute());
        WerbeautoButton.SetActive(false);
        AusgabeText.text = "werbeauto angeschafft";
    }

    IEnumerator Execute()
    {
        yield return StartCoroutine(DatenLesen());
        Auto();
        WerbeautoKosten();
        StartCoroutine(DatenSchreiben());
    }

    IEnumerator DatenLesen()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);

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
        form.AddField("user", GlobalVariables.username);

        //kundenschreiben php skript
        WWW www = new WWW("", form);
        yield return www;

    }
    public void Auto()
    {
        kundenAnzahl = kundenAnzahl + 10;        
    }

    public void WerbeautoKosten()
    {
        Geld = Geld - 1500;
    }
}
