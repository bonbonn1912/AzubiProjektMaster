using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Tvwerbung : MonoBehaviour
{
    int kundenAnzahl;
    double Geld;
    public GameObject TvwerbungButton;
    public TextMeshProUGUI AusgabeText;

    public void TvAusgabe()
    {
        StartCoroutine(Execute());
        TvwerbungButton.SetActive(false);
        AusgabeText.text = "fernsehwerbung geschaltet";
    }

    IEnumerator Execute()
    {
        yield return StartCoroutine(DatenLesen());
        TvAdds();
        TvWerbungKosten();
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
    
    public void TvAdds()
    {
        kundenAnzahl = kundenAnzahl + 120; //Dauer bis Rückgabe an Datenbank 
    }

    public void TvWerbungKosten()
    {
        Geld = Geld - 30000;
        //Rückgabe Geld an Datenbank
    }
}
