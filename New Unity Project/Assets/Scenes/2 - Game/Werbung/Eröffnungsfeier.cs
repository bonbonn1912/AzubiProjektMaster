//Autor: Thorge Siemens
//Stand: 07.05.2020

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System;

public class Eröffnungsfeier : MonoBehaviour
{
    int kundenAnzahl;
    double Geld;

    public void FeierAusgabe()
    {

        StartCoroutine(Execute());

    }

    IEnumerator Execute()
    {

        Debug.Log("Execute Methode bevor Coroutine gestartet wird");
        yield return StartCoroutine(DatenLesen());
        Debug.Log("Nach der Coroutine");
        Feier();
        FeierKosten();
        StartCoroutine(DatenSchreiben());
    }
    IEnumerator DatenLesen()
    {
        WWW www = new WWW("http://localhost/Test/kundenlesen.php");
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
        WWW www = new WWW("http://localhost/Test/kundenschreiben.php", form);
        yield return www;

    }
    public Text ausgabeFehler;
    public void Feier()
    {
        kundenAnzahl = kundenAnzahl + 30;
    }

    public void FeierKosten()
    {
        Geld = Geld - 2000;
    }
}
