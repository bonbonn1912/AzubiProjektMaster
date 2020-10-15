using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Rendering;

public class AktienKaufen : MonoBehaviour

 
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

    public AktienAnzahlAbfragen akutalisieren;
    string ShareName = "test";
    int Amount;
   public void buyAktie1()
    {
        Debug.Log("Aktie kann gekauft werden");
        InputFieldPlaceHolder.GetComponent<InputField>().text = "";
        InputFieldPlaceHolder.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        string Aktie = "Aktie1";
        int numberAktie1 = 1;
        buyAktie(Aktie, AktienKaufbarPruefung.AmountAktie1, numberAktie1);
        KaufErfolgreichAktie1.GetComponent<Text>().text = "Der Kauf von Aktie1 war erfolgreich";
    }

    public void buyAktie2()
    {
        InputFieldPlaceHolder1.GetComponent<InputField>().text = "";
        InputFieldPlaceHolder1.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        string Aktie = "Aktie2";
        int numberAktie2 = 2;
        buyAktie(Aktie, AktienKaufbarPruefung.AmountAktie2, numberAktie2);
        KaufErfolgreichAktie2.GetComponent<Text>().text = "Der Kauf von Aktie2 war erfolgreich";
    }

    public void buyAktie3()
    {
        InputFieldPlaceHolder2.GetComponent<InputField>().text = "";
        InputFieldPlaceHolder2.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        string Aktie = "Aktie3";
        int numberAktie3 = 3;
        buyAktie(Aktie, AktienKaufbarPruefung.AmountAktie3, numberAktie3);
        KaufErfolgreichAktie3.GetComponent<Text>().text = "Der Kauf von Aktie3 war erfolgreich";
    }

    public void buyAktie4()
    {
        InputFieldPlaceHolder3.GetComponent<InputField>().text = "";
        InputFieldPlaceHolder3.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        string Aktie = "Aktie4";
        int numberAktie4 = 4;
        buyAktie(Aktie, AktienKaufbarPruefung.AmountAktie4, numberAktie4);
        KaufErfolgreichAktie4.GetComponent<Text>().text = "Der Kauf von Aktie4 war erfolgreich";
    }

    public void buyAktie5()
    {
        InputFieldPlaceHolder4.GetComponent<InputField>().text = "";
        InputFieldPlaceHolder4.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        string Aktie = "Aktie5";
        int numberAktie5 = 5;
        buyAktie(Aktie, AktienKaufbarPruefung.AmountAktie5, numberAktie5);
        KaufErfolgreichAktie5.GetComponent<Text>().text = "Der Kauf von Aktie5 war erfolgreich";
    }


    public void buyAktie(string Aktie, int Amount, int number)
    {
        if(AktienKaufbarPruefung.KaufenAktie1 == true)
        {
            int numberinmethode = number;
            int amountinmethode = Amount;
            string AktieinMethode = Aktie;
            KaufenDatenBank(AktieinMethode, amountinmethode);
            KostenShares(AktieinMethode, amountinmethode, numberinmethode);
        }
    }




    public void KaufenDatenBank(string Aktienname, int AmountReal)
    {
        ShareName = Aktienname;
        Amount = AmountReal;
        Debug.Log("in KAufenDatenabnk");
        StartCoroutine(AktienKaufenDatenbank());
    }

    IEnumerator AktienKaufenDatenbank()
    {
       
        WWWForm AktieKaufen = new WWWForm();
        AktieKaufen.AddField("Username", GlobalVariables.username);
        AktieKaufen.AddField("shareName", ShareName);
        AktieKaufen.AddField("amount", Amount);

        Debug.Log("Username: " + GlobalVariables.username);
        Debug.Log("Sharename: " + ShareName);
        Debug.Log("amount: " + Amount);
        //  WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/BuyShares.php", AktieKaufen);
        WWW www = new WWW("https://dominikw.de/AzubiProjekt/BuyShares.php", AktieKaufen);
        yield return www;
        Debug.Log(www.text);
    }

    public void KostenShares(string Aktienname, int AmountReal, int number)
    {
        int Kurs = 0 ;
        if(number == 1)
        {
            Kurs = GlobalVariables.Aktie1KursGlob;
        }
        if(number == 2)
        {
            Kurs = GlobalVariables.Aktie2KursGlob;
        }
        if(number == 3)
        {
            Kurs = GlobalVariables.Aktie3KursGlob;
        }
        if(number == 4)
        {
            Kurs = GlobalVariables.Aktie4KursGlob;
        }
        if(number == 5)
        {
            Kurs = GlobalVariables.Aktie5KursGlob;
        }
        int Anzahl = AmountReal;
        
        int GK = Anzahl * Kurs;
        GlobalVariables.balance = GlobalVariables.balance - GK;

        StartCoroutine(UpdateKapital());
        akutalisieren.getAktienAnzahl();
    }

    IEnumerator UpdateKapital()
    {
        WWWForm KapitalUpdate = new WWWForm();
        KapitalUpdate.AddField("Username", GlobalVariables.username);
        KapitalUpdate.AddField("Balance", GlobalVariables.balance);
      //  WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/UpdateKreditBalance.php", KapitalUpdate);
        WWW www = new WWW("https://dominikw.de/AzubiProjekt/UpdateBalance.php", KapitalUpdate);
        yield return www;
        }
}
