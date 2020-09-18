//Autor: Thorge Siemens
//Stand: 07.05.2020

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System; 

public class OnlineWerbung : MonoBehaviour
{
    int kundenAnzahl;
    double Geld;
    public void OnlineAusgabe()
    {

        StartCoroutine(Execute());

    }

    IEnumerator Execute()
    {

        Debug.Log("Execute Methode bevor Coroutine gestartet wird");
        yield return StartCoroutine(DatenLesen());
        Debug.Log("Nach der Coroutine");
        WerbungOnline();
        OnlineWerbungKosten();
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
    public void WerbungOnline()
    {
        //Einlesen und Wertübergabe
        kundenAnzahl = kundenAnzahl + 180;
        Debug.Log("Test2 ");
        //Thread.Sleep(120000);   //Dauer bis Rückgabe an Datenbank 
    }

    public void OnlineWerbungKosten()
    {
        Geld = Geld - 45000;
        Debug.Log("Test 3");
    }
}
