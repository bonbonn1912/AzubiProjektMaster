using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AktienVerkaufen : MonoBehaviour
{

    public GameObject InputFieldPlaceHolder;
    public GameObject InputFieldPlaceHolder1;
    public GameObject InputFieldPlaceHolder2;
    public GameObject InputFieldPlaceHolder3;
    public GameObject InputFieldPlaceHolder4;

    public GameObject KaufErfolgreichAktie1;
    public GameObject KaufErfolgreichAktie2;
    public GameObject KaufErfolgreichAktie3;
    public GameObject KaufErfolgreichAktie4;
    public GameObject KaufErfolgreichAktie5;

    public AktienAnzahlAbfragen aktualisieren;
    string ShareName = "test";
    int Amount;

    public void SellAktie1()
    {
        
            InputFieldPlaceHolder.GetComponent<InputField>().text = "";
            InputFieldPlaceHolder.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        
        string Aktie = "Aktie1";
        int number = 1;
        sellAktie(Aktie,AktienVerkaufbarPruefung.AmountimDepotAktie1, number );
        KaufErfolgreichAktie1.GetComponent<Text>().text = "Aktie 1 wurde erfolgreich verkauft";

    }

    public void SellAktie2()
    {
        InputFieldPlaceHolder1.GetComponent<InputField>().text = "";
        InputFieldPlaceHolder1.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";

        string Aktie = "Aktie2";
        int number = 2;
        sellAktie(Aktie, AktienVerkaufbarPruefung.AmountimDepotAktie2, number);
        KaufErfolgreichAktie2.GetComponent<Text>().text = "Aktie 2 wurde erfolgreich verkauft";
    }

    public void SellAktie3()
    {
        InputFieldPlaceHolder2.GetComponent<InputField>().text = "";
        InputFieldPlaceHolder2.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";

        string Aktie = "Aktie3";
        int number = 3;
        sellAktie(Aktie, AktienVerkaufbarPruefung.AmountimDepotAktie3, number);
        KaufErfolgreichAktie3.GetComponent<Text>().text = "Aktie 3 wurde erfolgreich verkauft";
    }

    public void SellAktie4()
    {
        InputFieldPlaceHolder3.GetComponent<InputField>().text = "";
        InputFieldPlaceHolder3.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";

        string Aktie = "Aktie4";
        int number = 4;
        sellAktie(Aktie, AktienVerkaufbarPruefung.AmountimDepotAktie4, number);
        KaufErfolgreichAktie4.GetComponent<Text>().text = "Aktie 4 wurde erfolgreich verkauft";
    }

    public void SellAktie5()
    {
        InputFieldPlaceHolder4.GetComponent<InputField>().text = "";
        InputFieldPlaceHolder4.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";

        string Aktie = "Aktie5";
        int number = 5;
        sellAktie(Aktie, AktienVerkaufbarPruefung.AmountimDepotAktie5, number);
        KaufErfolgreichAktie5.GetComponent<Text>().text = "Aktie 5 wurde erfolgreich verkauft";
    }

    public void sellAktie(string Aktie, int Amount, int number)
    {
        int numberinmethode = number;
        int amountinmethode = Amount;
        string AktieinMethode = Aktie;
        VerkaufenDatenBank(AktieinMethode, amountinmethode);
        ErloesShares(AktieinMethode, amountinmethode, numberinmethode);
    }

    public void VerkaufenDatenBank(string Aktienname, int AmountReal)
    {
        ShareName = Aktienname;
        Amount = AmountReal;
        StartCoroutine(AktienVerkaufenDatenbank(ShareName, Amount));


    }

    IEnumerator AktienVerkaufenDatenbank(String Sharename, int Amount)
    {
        WWWForm AktienVerkaufen = new WWWForm();
        AktienVerkaufen.AddField("Username", GlobalVariables.username);
        AktienVerkaufen.AddField("shareName", ShareName);
        AktienVerkaufen.AddField("amount", Amount);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/SellShares.php", AktienVerkaufen);
        yield return www;
    }

     public void ErloesShares(string Aktienname, int AmountReal, int number)
    {
        int Kurs = 0;
        if (number == 1)
        {
            Kurs = GlobalVariables.Aktie1KursGlob;
        }
        if (number == 2)
        {
            Kurs = GlobalVariables.Aktie2KursGlob;
        }
        if (number == 3)
        {
            Kurs = GlobalVariables.Aktie3KursGlob;
        }
        if (number == 4)
        {
            Kurs = GlobalVariables.Aktie4KursGlob;
        }
        if (number == 5)
        {
            Kurs = GlobalVariables.Aktie5KursGlob;
        }
        int Anzahl = AmountReal;
        int GE = Anzahl * Kurs;
        GlobalVariables.balance = GlobalVariables.balance + GE;
        StartCoroutine(UpdateKapital());
        aktualisieren.getAktienAnzahl();
    }
    IEnumerator UpdateKapital()
    {
        WWWForm KapitalUpdate = new WWWForm();
        KapitalUpdate.AddField("Username", GlobalVariables.username);
        KapitalUpdate.AddField("Balance", GlobalVariables.balance);
        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/UpdateKreditBalance.php", KapitalUpdate);
        yield return www;
    }

}
