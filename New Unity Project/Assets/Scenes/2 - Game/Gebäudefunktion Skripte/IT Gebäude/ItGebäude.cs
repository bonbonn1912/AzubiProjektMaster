using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class ItGebäude : MonoBehaviour
{
    int Mitarbeiter = 0;
    int Ertrag = 0;
    int Stufe = 1;
    double Kapital = 0;



    public void MitarbeiterErtragErhöhung()
    {
        StartCoroutine(Execute());
    }

    IEnumerator Execute()
    {
        yield return StartCoroutine(DatenLesen());
        MitarbeiterErtrag();   
        StartCoroutine(DatenSchreiben());
    }

    IEnumerator DatenLesen()
    {
        WWW www = new WWW("http://localhost/sqlconnect/ErtragLesen.php");
        yield return www;
        string mitarbeiterDB = www.text.Split('-')[0];
        string geldDB = www.text.Split('-')[1];
        string stufeITDB = www.text.Split('-')[2];
        Kapital = Convert.ToDouble(geldDB);
        Mitarbeiter = Convert.ToInt32(mitarbeiterDB);
        Stufe = Convert.ToInt32(stufeITDB);
        Debug.Log("\nMitarbeiter " + Mitarbeiter + "\nKapital " + Kapital + "\nStufe " + Stufe);
    }

    IEnumerator DatenSchreiben()
    {
        string kapital = Convert.ToString(Kapital);
        string ertrag = Convert.ToString(Ertrag);
        WWWForm form = new WWWForm();
        form.AddField("Kapital", kapital);
        form.AddField("Ertrag", ertrag);
        WWW www = new WWW("http://localhost/sqlconnect/KapitalSchreiben.php", form);
        yield return www;
    }


    public void MitarbeiterErtrag()
    {
        Ertrag = 100 * Stufe;
        Debug.Log("\nErtrag " + Ertrag);
    }

   
}
