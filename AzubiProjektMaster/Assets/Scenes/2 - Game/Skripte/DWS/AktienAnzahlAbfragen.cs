using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AktienAnzahlAbfragen : MonoBehaviour
{

    public Text AmountAktie1;
    public Text AmountAktie2;
    public Text AmountAktie3;
    public Text AmountAktie4;
    public Text AmountAktie5;
   public void getAktienAnzahl()
    {

        StartCoroutine(FetchAktienAnzahl());

    }

    IEnumerator FetchAktienAnzahl()
    {
        
        Debug.Log("Aktienanzahl wird abgefragt");
        WWWForm FetchShares = new WWWForm();
        
        FetchShares.AddField("user", GlobalVariables.username);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/FetchShares.php", FetchShares);
        yield return www;

        string [] stringAmounts = www.text.Split('/');

        AmountAktie1.text = stringAmounts[0];
        AmountAktie2.text = stringAmounts[1];
        AmountAktie3.text = stringAmounts[2];
        AmountAktie4.text = stringAmounts[3];
        AmountAktie5.text = stringAmounts[4];



    }
}
