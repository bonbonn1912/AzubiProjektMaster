﻿using System;
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
   
    public int ValueMin;
    public int ValueMax;
    public int Value;
    public int Duration;
    
    public void GenerateKredit()
    {
        GenerateCreditValue();
        GenerateDuration();
        GenerateName();
        
    }

    public void AcceptKredit()
    {
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
        Debug.Log(www.text);
    }

    string GenerateName()
    {
        string[] s = { "Dominik", "Sebastian", "Patrick", "Pedram", "Torge", "Colin", "Patrik", "Maurice", "Elena", "Frederick", "Ahmet","Cara","Matthias","Bettina","Filiz","Justin", "Thorge", "Anas" };
        int Postiion;
        Postiion = Random.Range(0, s.Length);
        Kunde.text = s[Postiion];
        return s[Postiion];
        


    }

    int GenerateCreditValue()
    {
        ValueMin = GlobalVariables.balance / 100;
        ValueMax = GlobalVariables.balance / 10;
        Value = Random.Range(ValueMin, ValueMax);
        Volumen.text = Convert.ToString(Value);
        return Value;
    }

    int GenerateDuration()
    {
        Duration = Random.Range(GlobalVariables.minDuration, GlobalVariables.maxDuration);
        Laufzeit.text = Convert.ToString(Duration);
        return Duration;
    }


}
