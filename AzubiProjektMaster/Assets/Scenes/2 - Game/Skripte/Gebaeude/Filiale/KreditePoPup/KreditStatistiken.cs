using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class KreditStatistiken : MonoBehaviour
{
    public Text KreditAnzahl;
    public Text GesamtVolumen;
    public Text KrediteAnTagX;
    int Gesamtvolumen;
    public UnityEngine.UI.Button Vergeben;

    public void Start()
    {
        if(GlobalVariables.balance < 0)
        {
            Vergeben.interactable = false;
        }
        if(GlobalVariables.balance > 1000)
        {
            Vergeben.interactable = true;
        }
    }

    public void statistike()
    {
        StartCoroutine(CreditCount());
        StartCoroutine(CreditVolume());
    }

    

    IEnumerator CreditCount()
    {
        WWWForm creditcount = new WWWForm();
        creditcount.AddField("username", GlobalVariables.username);

        // WWW creditabfrage = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/AnzahlKrediteDEV.php", creditcount);
        // WWW creditabfrage = new WWW("https://dominikw.de/AzubiProjekt/AnzahlKredite.php", creditcount);
        WWW creditabfrage = new WWW("https://dominikw.de/AzubiProjekt/AnzahlKrediteDEV.php", creditcount);
        yield return creditabfrage;
        Debug.Log("Anzahl Kredite" +creditabfrage.text);
        KreditAnzahl.text = creditabfrage.text;
        KrediteAnTagX.text = Convert.ToString(GlobalVariables.day);
        GlobalVariables.anzahlKredite = Convert.ToInt32(creditabfrage);
    }

    IEnumerator CreditVolume()
    {
        Gesamtvolumen = 0;
        WWWForm creditvolume = new WWWForm();
        creditvolume.AddField("user", GlobalVariables.username);

      //  WWW volumeabfrage = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/KreditGesamtVolumenDEV.php", creditvolume);
     //   WWW volumeabfrage = new WWW("https://dominikw.de/AzubiProjekt/KreditGesamtVolumen.php", creditvolume);
        WWW volumeabfrage = new WWW("https://dominikw.de/AzubiProjekt/KreditGesamtVolumenDEV.php", creditvolume);
        yield return volumeabfrage;
        string[] volume = volumeabfrage.text.Split('-');
        int[] a = new int[volume.Length];
        for(int i = 0; i < volume.Length-1; i++)
        {
            int temp;
            a[i] = int.Parse(volume[i]);
            Gesamtvolumen += a[i];
            
        }
        

        GesamtVolumen.text = Convert.ToString(Gesamtvolumen) + "€";
        
    }


}
