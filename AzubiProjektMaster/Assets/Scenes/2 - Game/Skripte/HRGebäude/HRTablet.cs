using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class HRTablet : MonoBehaviour
{
    public GameObject hrTablet;
    
    public Text AnzahlMA;
    public Text Zaehler;
    public Text KostenAE;
    public Text PersonalCost;
    int Kosten = 1000;
    int EKosten = 500;
    int zaehler = 0;




    public void Entlassen()
    {
        zaehler--;
       // AnzahlMA.text = "Aktuelle Mitarbeiter Anzahl: " + GlobalVariables.mitarbeiter;
        if (zaehler > 0)
        {
            Zaehler.text = "Anzahl neuer Mitarbeiter: " + zaehler;
            KostenAE.text = "Kosten: " + zaehler * Kosten+" €";
        }
        else
        {
            Zaehler.text = "Anzahl Entlassener Mitarbeiter: " + zaehler * (-1);
            KostenAE.text = "Kosten: " + zaehler*(-1) * EKosten +" €";
        }

        Debug.Log("Globale Mitarbeiter: " + GlobalVariables.mitarbeiter);
        Debug.Log("Zaehler: " + zaehler);
        //GlobalVariables.mitarbeiter = employeestemp;





    }
    public void Einstellen()
    {
        zaehler++;
        if (zaehler < 0)
        {
            Zaehler.text = "Anzahl Entlassener Mitarbeiter:" + zaehler * (-1);
            KostenAE.text = "Kosten: " + zaehler * (-1) * EKosten + " €";
        }
        else
        {
            Zaehler.text = "Anzahl neuer Mitarbeiter:" + zaehler;
            KostenAE.text = "Kosten: " + zaehler * Kosten + " €";
        }
     //   AnzahlMA.text = "Aktuelle Mitarbeiter Anzahl: " + GlobalVariables.mitarbeiter;
        
        Debug.Log("Globale Mitarbeiter: " + GlobalVariables.mitarbeiter);
        Debug.Log("Zaehler: " + zaehler);
    }
    public void SubmitButton()
    {
        //Einstellen 
        if (zaehler >= 0)
        {
            if (zaehler * Kosten > GlobalVariables.balance)
            {
                Debug.Log("Sie haben nicht genug Kapital");
            }
            else
            {
                Debug.Log("Altes Kapital:" + GlobalVariables.balance);
                Debug.Log("Sie haben genug Geld");
                int Gesamtkosten = zaehler * Kosten;
                GlobalVariables.balance = GlobalVariables.balance - Gesamtkosten;
                GlobalVariables.mitarbeiter = GlobalVariables.mitarbeiter + zaehler;

                StartCoroutine(UpdateKapital());
                zaehler = 0;
                Zaehler.text = "";
                KostenAE.text = "";
                PersonalCost.text = GlobalVariables.mitarbeiter * GlobalVariables.PersonalCost + " €";
                AnzahlMA.text = Convert.ToString(GlobalVariables.mitarbeiter);
                // SceneManager.LoadScene(3);
            }
        }
        //Entlassen
        else
        {
            if (GlobalVariables.mitarbeiter + zaehler < 0)
            {
                Debug.Log("Sie dürfen nicht so viele Mitarbeiter entlassen ");
            }
            else
            {
                int EntlassungKosten = zaehler * (-1) * EKosten;
                GlobalVariables.balance = GlobalVariables.balance - EntlassungKosten;
                GlobalVariables.mitarbeiter = GlobalVariables.mitarbeiter - zaehler*-1;
                StartCoroutine(UpdateKapital());
                zaehler = 0;
                Zaehler.text = "";
                KostenAE.text = "";
                AnzahlMA.text = Convert.ToString(GlobalVariables.mitarbeiter);
                PersonalCost.text = GlobalVariables.mitarbeiter * GlobalVariables.PersonalCost + " €";
                // SceneManager.LoadScene(3);
            }
        }


    }
    public void CloseTablet()
    {
        hrTablet.SetActive(false);
    }
    IEnumerator UpdateKapital()
    {
        string username = GlobalVariables.username;
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("Balance", GlobalVariables.balance);
        form.AddField("Employees", GlobalVariables.mitarbeiter);
        // WWW www = new WWW("http://dominik.grandpa-kitchen.com/PHP-Skripte/BalanceUpdateMA.php", form);
        WWW www = new WWW("https://dominikw.de/AzubiProjekt/BalanceUpdateMA.php", form);
        // Debug.Log("Neues Kapital:" + GlobalVariables.balance);
        yield return www;
    }
}



