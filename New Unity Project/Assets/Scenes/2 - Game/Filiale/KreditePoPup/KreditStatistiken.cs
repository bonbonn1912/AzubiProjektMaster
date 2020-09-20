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
    int Gesamtvolumen;
    public void statistike()
    {
        StartCoroutine(CreditCount());
        StartCoroutine(CreditVolume());
    }



    IEnumerator CreditCount()
    {
        WWWForm creditcount = new WWWForm();
        creditcount.AddField("username", GlobalVariables.username);

        WWW creditabfrage = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/AnzahlKredite.php", creditcount);
        yield return creditabfrage;
        KreditAnzahl.text = creditabfrage.text;
    }

    IEnumerator CreditVolume()
    {
        Gesamtvolumen = 0;
        WWWForm creditvolume = new WWWForm();
        creditvolume.AddField("user", GlobalVariables.username);

        WWW volumeabfrage = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/KreditGesamtVolumen.php", creditvolume);
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
