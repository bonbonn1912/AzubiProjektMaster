using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;



public class Mitarbeiterentlassen : MonoBehaviour
{
    int Mitarbeiter = 0;
    int Kosten = 0;
    int Kapital = 0;
    public void MitarbeiterEntlassen()
    {
        StartCoroutine(Execute());
    }

    IEnumerator Execute()
    {
        yield return StartCoroutine(DatenLesen());
        Entlassen();
        StartCoroutine(DatenSchreiben());
    }

    IEnumerator DatenLesen()
    {
        WWW www = new WWW("http://localhost/sqlconnect/MitarbeiterEntlassenLesen.php");
        yield return www;
        string mitarbeiterDB = www.text.Split('-')[0];
        string mitarbeiterKostenDB = www.text.Split('-')[1];
        string KapitalDB = www.text.Split('-')[2];
        Mitarbeiter = Convert.ToInt32(mitarbeiterDB);
        Kosten = Convert.ToInt32(mitarbeiterKostenDB);
        Kapital = Convert.ToInt32(KapitalDB);
    }

    IEnumerator DatenSchreiben()
    {
        string mitarbeiter = Convert.ToString(Mitarbeiter);
        string kosten = Convert.ToString(Kosten);
        string kapital = Convert.ToString(Kapital);
        WWWForm form = new WWWForm();
        form.AddField("Mitarbeiter", mitarbeiter);
        form.AddField("Kosten", kosten);
        form.AddField("Kapital", kapital);
        WWW www = new WWW("http://localhost/sqlconnect/MitarbeiterEntlassenSchreiben.php", form);
        yield return www;
    }


    private void Entlassen()
    {
        if( Mitarbeiter>=1 )
        {
            Mitarbeiter--;
            Kapital = Kapital - 500;
            if(Kosten >= 2000)
            {
                Kosten = Kosten - 1000;
                Debug.Log("\nAngestellte: " + Mitarbeiter);
            }
            
        }
        else
        {
            Debug.Log("\nNicht genug Mitarbeiter");
        }
        
    }

}
