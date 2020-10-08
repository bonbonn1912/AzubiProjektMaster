using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
public class KreditGenerieren : MonoBehaviour
{
    public Text Kunde;
    public Text Laufzeit;
    public Text Volumen;
    public Text ZinsenTxt;
    public Text GewinnTxt;
    public GameObject App;
    public GameObject Success;
    public GameObject Management;
    public GameObject Abgelehnt;
    public Button Accept;
    public Button Deny;
    public Button Back;
    
   
    public int ValueMin;
    public int ValueMax;
    public float Value;
    public int Duration;
    public int volumen;
    public float Zinsen;
    public float Gewinn;
    
    public void GenerateKredit()
    {
        GenerateCreditValue();
        GenerateDuration();
        GenerateName();
        
    }

    public void AcceptKredit()
    {
        if(Success != null)
        {
            Success.SetActive(true);
            Accept.interactable = false;
            Deny.interactable = false;
            Back.interactable = false;
        }
        // Debug.Log("Kredit wird in Datenbank geschrieben:");
        StartCoroutine(PushintoDB());
    }

    

    IEnumerator PushintoDB()
    {

        
        WWWForm form = new WWWForm();
        string name = Kunde.text;
        string laufzeit = Laufzeit.text;
        string volume = Volumen.text;
        form.AddField("Berater", GlobalVariables.username);
        form.AddField("Name", Kunde.text);
        form.AddField("Laufzeit", Laufzeit.text);
        form.AddField("Volume", Volumen.text);
        // Debug.Log("Folgende Werte werden inserted Name: " + name + " Runtime: " + laufzeit + " Volume: " + volume);
        WWW www = new WWW("http://dominik.grandpa-kitchen.com/PHP-Skripte/InsertCredits.php", form);
        
        yield return www;

        GlobalVariables.balance = GlobalVariables.balance - Convert.ToInt32(Volumen.text);
        WWWForm form1 = new WWWForm();
        form1.AddField("Username", GlobalVariables.username);
        form1.AddField("Balance", GlobalVariables.balance);
        WWW www1 = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/UpdateKreditBalance.php", form1);

        yield return www1;
        //Debug.Log(www.text);
    }

    string GenerateName()
    {
        string[] s = { "Dominik", "Sebastian", "Patrick", "Pedram", "Torge", "Colin", "Patrik", "Maurice", "Elena", "Frederick", "Ahmet","Cara","Matthias","Bettina","Filiz","Justin", "Thorge", "Anas" };
        int Postiion;
        Postiion = Random.Range(0, s.Length);
        Kunde.text = s[Postiion];
        return s[Postiion];
        


    }

    float GenerateCreditValue()
    {
        ValueMin = GlobalVariables.balance / 100;
        ValueMax = GlobalVariables.balance / 10;
        Value = Random.Range(ValueMin, ValueMax);
        Volumen.text = Convert.ToString(Value);
        Zinsen = Random.Range(0.001f, 0.05f);
        Gewinn = Value * Zinsen;
        //Debug.Log("Gewinn vor Rundung: " + Gewinn);
        Gewinn = Mathf.Round(Gewinn);
        //Debug.Log("Value vor dem neu Berechnen: " + Value);
        Value = Value + Gewinn;
        ZinsenTxt.text = Convert.ToString(Zinsen * 100);
        GewinnTxt.text = Convert.ToString(Gewinn);
        //Debug.Log("Zinsen: " + Zinsen + "Gewinn: " + Gewinn + "Value: " + Value);
        return Value;
    }

    int GenerateDuration()
    {
        Duration = Random.Range(GlobalVariables.minDuration, GlobalVariables.maxDuration);
        Laufzeit.text = Convert.ToString(Duration);
        return Duration;
    }
     public void BackToManagement()
    {
        Success.SetActive(false);
        App.SetActive(false);
        Management.SetActive(true);
        Accept.interactable = true;
        Deny.interactable = true;
        Back.interactable = true;

    }


    public void Ablehnen()
    {
        if (Abgelehnt != null)
        {
            Abgelehnt.SetActive(true);
            Accept.interactable = false;
            Deny.interactable = false;
            Back.interactable = false;
        }
    }
    public void AblehnenUnsichtbar()
    {
        Abgelehnt.SetActive(false);
    }

}
