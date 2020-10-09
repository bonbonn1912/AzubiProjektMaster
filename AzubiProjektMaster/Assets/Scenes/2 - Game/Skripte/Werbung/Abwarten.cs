using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Abwarten : MonoBehaviour
{
    int kundenAnzahl;
    
    public void AbwartenAusgabe()
    {
        StartCoroutine(Execute());
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
        
        //kundenlesen
        WWW www = new WWW();
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

        //kundenschreiben
        WWW www = new WWW();
        yield return www;
    }

    public void Warten()
    {
        kundenAnzahl = kundenAnzahl + 10;
    }
}
