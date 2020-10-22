using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GenerateEvent : MonoBehaviour
{
    public GameObject Headline;
    public GameObject Body;
    public GameObject Auswirkung;
    public GameObject AuswirkungsPanel;
    public Text RealAuswirkungText;


    public int Value;

    public static int vorzeichen;
    public static int Evalue;
    public static int KundenVorzeichen;
    public static int aktuellesEvent;

   
    public void TriggerDecision()
    {
        int a = Random.Range(1, 11);

        if (a <=3)
        {
            TriggerNegativEvent(a);
        }
        if(a>3 && a<8)
        {
           TriggerNeutralEvent(a);
        }
        if (a >= 8)
        {
            TriggerPositivEvent(a);
        }

    }

    public void TriggerNegativEvent(int a)
    {
        switch(a)
        {
            case 1:
                {
                   // int b = generateNegativeAuswirkung();
                    Headline.GetComponent<Text>().text = "Überfall";
                    Body.GetComponent<Text>().text = "Eins deiner Gebäude wird überfallen. Möchtest du die Polizei rufen?";
                   // Auswirkung.GetComponent<Text>().text =  "Dies kostet dich: " + b + "€";
                    // TriggerEvent(b, 0);
                    Evalue = 0;
                    vorzeichen = 0;
                    aktuellesEvent = 1;
                    break;
                }
            case 2:
                {
                    int b = generatePositiveAuswirkung();
                    Headline.GetComponent<Text>().text = "Feuerwehrübung";
                    Body.GetComponent<Text>().text = "Laut Plan stehen freiwillige Feuerwehrübungen an. Willst du diese wirklich durchführen?";
                  //  Auswirkung.GetComponent<Text>().text = "Dies kostet dich: " + b + "€";
                    //  TriggerEvent(b, 0);
                    Evalue = b;
                    vorzeichen = 1;
                    aktuellesEvent = 2;
                    break;
                }
            case 3:
                {
                    int b = generateNegativeAuswirkung();
                    Headline.GetComponent<Text>().text = "Es brennt!!!";
                    Body.GetComponent<Text>().text = "Es ist ein Feuer in einem deiner Gebäude ausgebrochen. Möchtest du das Gebäude räumen?";
                  //  Auswirkung.GetComponent<Text>().text = "Dies kostet dich: " + b + "€";
                    //  TriggerEvent(b, 0);
                    Evalue = b;
                    vorzeichen = 0;
                    aktuellesEvent = 3;
                    break;
                }

        }
    }

    public void TriggerNeutralEvent(int a)
    {
        switch (a)
        {
            case 4:
                {
                    int b = generateNegativeAuswirkung();
                    Headline.GetComponent<Text>().text = "Globale Pandemie!";
                    Body.GetComponent<Text>().text = "Es ist ein Virus ausgebrochen. Möchtest du deine Mitarbeiter ins Home Office schicken ?";
                    //  Auswirkung.GetComponent<Text>().text = "Dies bringt dir: " + b + "€";
                    //  StartCoroutine(Execute(b, 1));
                    aktuellesEvent = 4;
                    break;
                }
            case 5:
                {
                    int b = generateNeutraleAuswirkung();
                    Headline.GetComponent<Text>().text = "Finanzamt";
                    Body.GetComponent<Text>().text = "Es gab eine Überprüfung des Finanzamts wegen Steuerhinterziehung. Sie konnten nichts finden, doch der Ruf der Bank wurde beschädigt. Soll eine Stellungnahme veröffentlicht werden ?";
                    //   Auswirkung.GetComponent<Text>().text = "Dies bringt dir: " + b + "€";
                    //   StartCoroutine(Execute(b, 1));
                    aktuellesEvent = 5;
                   
                    break;
                }
            case 6:
                {
                    int b = generateNeutraleAuswirkung();
                    Headline.GetComponent<Text>().text = "Sicherheitslücken";
                    Body.GetComponent<Text>().text = "Mitarbeiter haben Sicherheitslücken in deinen Systemem gefunden. Soll ein Spezialist angestellt werden, um das Problem zu beheben ?";
                    //  Auswirkung.GetComponent<Text>().text = "Dies bringt dir: " + b + "€";
                    //   StartCoroutine(Execute(b, 1));
                    aktuellesEvent = 6;
                    break;
                }
            case 7:
                {
                   
                    Headline.GetComponent<Text>().text = "Negative Doku";
                    Body.GetComponent<Text>().text = "Es wurde eine Dokumentation mit schlechten Aspekten deiner Bank dargestellt. Soll ein Statement abgebeben werden ?";
                    //  Auswirkung.GetComponent<Text>().text = "Dies bringt dir: " + b + "€";
                    //    StartCoroutine(Execute(b, 1));
                    aktuellesEvent = 7;
                    break;
                }

        }
    }

    public void TriggerPositivEvent(int a)
    {
        switch (a)
        {
            case 8:
                {
                    int b = generatePositiveAuswirkung();
                    Headline.GetComponent<Text>().text = "Überschwemmungen";
                    Body.GetComponent<Text>().text = "Es gab eine Überschwemmung in einer deiner Gebäude. Soll deinen Mitarbeitern geholfen werden ?";
                  //  Auswirkung.GetComponent<Text>().text = "Dies bringt dir: " + b + "€";
                    //   StartCoroutine(Execute(b, 1));
                   aktuellesEvent = 8;
                    break;
                }
            case 9:
                {
                    int b = generatePositiveAuswirkung();
                    Headline.GetComponent<Text>().text = "Goldbarren";
                    Body.GetComponent<Text>().text = "Es wurden Goldbarren im Keller einer deiner Gebäude gefunden (Wert: 100.000 €). Soll ein Teil der Summe gespendet werden?";
                  
                    aktuellesEvent = 9;
                    break;
                }
            case 10:
                {
                    int b = generatePositiveAuswirkung();
                    Headline.GetComponent<Text>().text = "Dokumentation";
                    Body.GetComponent<Text>().text = "Es soll eine Dokumentation über die Bank gedreht werden. Lässt du dies zu?";
                    //   Auswirkung.GetComponent<Text>().text = "Dies bringt dir: " + b + "€";
                    // StartCoroutine(Execute(b, 1));
                    aktuellesEvent = 10;
                    break;
                }
            case 11:
                {
                    int b = generatePositiveAuswirkung();
                    Headline.GetComponent<Text>().text = "Bärenausbruch";
                    Body.GetComponent<Text>().text = "In deiner Nachbarstadt ist ein Bär aus dem Zoo ausgebrochen. Laut Zeugenaussagen wurde der Bär zuletzt in deiner Stadt gesichtet. Willst du das Gebäude abriegeln?";
                    //   Auswirkung.GetComponent<Text>().text = "Dies bringt dir: " + b + "€";
                    //   StartCoroutine(Execute(b, 1));
                    aktuellesEvent = 11;
                    break;
                }
            case 12:
                {
                    int b = generatePositiveAuswirkung();
                    Headline.GetComponent<Text>().text = "Neuer Vorstand gewählt";
                    Body.GetComponent<Text>().text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, " +
                        "sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. " +
                        "At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus " +
                        "est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod " +
                        "tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo " +
                        "dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";
                //    Auswirkung.GetComponent<Text>().text = "Dies bringt dir: " + b + "€";
                    //  StartCoroutine(Execute(b, 1));
                    Evalue = b;
                    vorzeichen = 1;
                    break;
                }

        }
    }
    public void AcceptEvent()
    {
        switch (aktuellesEvent)
        {
            case 1:
                {
                    Debug.Log("Accept aktuelles Event");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Die Polizei wird gerufen. Sie ergreifen den Täter. Dies führt zu keinem Verlust";
                    Evalue = 0;
                    vorzeichen = 0;
                    TriggerEvent(Evalue, vorzeichen);
                    break;
                }
            case 2:
                {
                    Debug.Log("Event 2 - Übungen");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Es werden Übungen durchgeführt. Deine Mitarbeiter fühlen sich sicherer. Dies spiegelt sich in einem kleinem finanziellen Bonus wieder";
                    Evalue = generatePositiveAuswirkung() / 10;
                    Debug.Log("Event Value" + Evalue);
                    vorzeichen = 1;
                    TriggerEvent(Evalue, vorzeichen);

                      break;
                }
            case 3:
                {
                    Debug.Log("Event 3 - Es brennt!");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Das Gebäude wird geräumt und die Feuerwehr gerufen. Es entsteht ein Schaden von 20000€. Zum Glück wurde keiner verletzt";
                    Evalue = 20000;
                    Debug.Log("Event Value" + Evalue);
                    vorzeichen = 0;
                    TriggerEvent(Evalue, vorzeichen);

                    break;
                }
            case 4:
                {
                    Debug.Log("Event 4 - Globale Pandemie");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Deine Mitarbeiter werden ins Homeoffice geschickt!";
                    GlobalVariables.cooldownday = GlobalVariables.day + 14;
                   // GlobalVariables.Mitarbeitergewinn = GlobalVariables.Mitarbeitergewinn;
                    break;
                }
            case 5:
                {
                    Debug.Log("Event 5 - Finanzamt");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Es wird eine Stellungname abgegeben. Die Kunden beruhigen sich und der Ruf wird wiederhergestellt";
                    break;

                }
            case 6:
                {
                    Debug.Log("Event 6 - Sicherheitslücken");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Ein Spezialist wird hinzugezogen und das Problem wird behoben. Die Kosten belaufen sich auf 4000€";
                    Evalue = 4000;
                    vorzeichen = 0;
                    TriggerEvent(Evalue, vorzeichen);
                    break;
                }
            case 7:
                {
                    Debug.Log("Event 7 - Doku");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Es wird ein Statement abgegeben. Deine Kunden & die Aktionäre beruhigen sich";
                    
                    break;
                }
            case 8:
                {
                    Debug.Log("Event 8 - Flut");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Es werden Handtücher und heiße Schokolade verteilt.";

                    break;
                }
            case 9:
                {
                    Debug.Log("Event 9 - Goldbarren");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Durch die Spende erhöht sich dein Ruf. Dies führt zu einem finanziellen Bonus";
                    Evalue = 10000;
                    vorzeichen = 1;
                    TriggerEvent(Evalue, vorzeichen);

                    break;
                }
            case 10:
                {
                    Debug.Log("Event 10 - Positive Doku");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Durch die Spende erhöht sich dein Ruf. Dies führt zu einem finanziellen Bonus";
                    Evalue = 20000;
                    int Kundenvalue = 10;
                    vorzeichen = 1;
                    TriggerEvent(Evalue, vorzeichen);
                    TrigerKundenEvent(Kundenvalue, 1);

                    break;
                }
            case 11:
                {
                    Debug.Log("Event 11 - Bär");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Das Gebäude wird abgeriegelt. Niemand wird verletzt und es entsteht kein Schaden";
                    

                    break;
                }
        }
       // TriggerEvent(Evalue, vorzeichen);
        


    }

   

    public void DenyEvent()
    {
        switch (aktuellesEvent)
        {
            case 1:
                {
                    Debug.Log("Deny aktuelles Event");
                    int b = generateNegativeAuswirkung() / 10;
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Die Polizei wird nicht gerufen. Der Täter entkommt mit einer großen Summe. Außerdem wird die Handtasche einer Großmutter geklaut die daraufhin ihr Konto bei der Bank kündigt";
                    int Kunde = 1;
                    Evalue = b;
                    vorzeichen = 0;
                    KundenVorzeichen = 0;
                    TriggerEvent(Evalue, vorzeichen);
                    TrigerKundenEvent(1,KundenVorzeichen);

                    break;
                }
            case 2:
                {
                    Debug.Log("Deny aktuelles Event");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Es werden keine Übungen durchgeführt.Im Fall eines Brandes ist mit mehr Panik zu rechnen.";
                    break;
                }
            case 3:
                {
                    Debug.Log("Deny aktuelles Event");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Das Gebäude wird nicht geräumt. Es kommt zu einem Schaden von 20000€. Außerdem werden 3 Kunden verletzt weswegen du 6000€ Schmerzensgeld zahlen musst.";
                    Evalue = 26000;
                    vorzeichen = 0;
                    TriggerEvent(Evalue, vorzeichen);
                    break;
                }
            case 4:
                {
                    Debug.Log("Deny aktuelles Event");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Deine Mitarbeiter werde nicht ins Homeoffice geschickt. Die Hälfte deiner Mitarbeiter erkrankt und kann für 2 Wochen nicht arbeiten. Dies reduziert deinen Gewinn für diesen Monat";
                    break;
                }
            case 5:
                {
                    Debug.Log("Deny aktuelles Event");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Es wird keine Stellungnahme abgegeben. Ein Teil deiner Kunden verschwindet zur Konkurrenz";
                    KundenVorzeichen = 0;
                    TrigerKundenEvent(Random.Range(1, 10), KundenVorzeichen);
                    break;
                }
            case 6:
                {
                    Debug.Log("Deny aktuelles Event");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Es findet ein Hackerangriff statt. Die Angreifer konnten einige Daten stehen. Du musst deinen Kunden eine Entschädigung zahlen";
                    Evalue = generateNegativeAuswirkung() / 2;
                    vorzeichen = 0;
                    TriggerEvent(Evalue, vorzeichen);
                    break;

                }
            case 7:
                {
                    Debug.Log("Deny aktuelles Event");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Die Dokumentation führt dazu dass einige Kunden die Bank verlassen";
                    KundenVorzeichen = 0;
                    TrigerKundenEvent(Random.Range(1, 5), KundenVorzeichen);


                    break;
                }
            case 8:
                {
                    Debug.Log("Deny aktuelles Event");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Es wird nicht geholfen. 5 Mitarbeiter erkranken. Dies führt zu einem reduzierten Gewinn für diesen Monat";

                    break;
                }
            case 9:
                {
                    Debug.Log("Deny aktuelles Event");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Du entscheidest dich gegen eine Spende. Dies hat keine Auswirkungen";
                   
                    

                    break;
                }
            case 10:
                {
                    Debug.Log("Deny aktuelles Event");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Du lehnst den Dreh der Doku ab";
                   
                 

                    break;
                }
            case 11:
                {
                    Debug.Log("Deny aktuelles Event");
                    AuswirkungsPanel.SetActive(true);
                    RealAuswirkungText.text = "Deine Mitarbeiter gehen auf die Suche nach dem Bären. Einige Mitarbeiter werden verletzt und werden ins Krankenhaus gebracht. Dies mindert deinen Gesamtgewinn";
                    break;
                }
        }
    }

   

    public void BackToGame()
    {

    }

    public int generateNegativeAuswirkung()
    {
        int b = Random.Range(GlobalVariables.balance/10, GlobalVariables.balance/2);
        return b;
    }

    public int generateNeutraleAuswirkung()
    {
        int b = Random.Range(GlobalVariables.balance / 20, GlobalVariables.balance / 10);
        return b;
    }
    public int generatePositiveAuswirkung()
    {
        int b = Random.Range(GlobalVariables.balance / 5, GlobalVariables.balance / 2);
        return b;
    }

    

    public void TriggerEvent(int value, int vorzeichen)
    {
        Debug.Log("in trgger");
        StartCoroutine(Execute(value, vorzeichen));
       
    }

    public void TrigerKundenEvent(int value, int vorzeichen)
    {
        Debug.Log("in Kundentrigger");
        StartCoroutine(ExecuteKunden(value, vorzeichen));

    }

    IEnumerator Execute(int value, int vorzeichen)
    {
        //Debug.Log("in coroutine");
       //  yield return new WaitForSeconds(1.5f);
        switch (vorzeichen)
        {
            case 0:
                {
                    Debug.Log("Alte Balance" + GlobalVariables.balance);
                    GlobalVariables.balance = GlobalVariables.balance - value;
                    Debug.Log("Neue Balance" + GlobalVariables.balance);
                    WWWForm BalanceUpdate = new WWWForm();
                    BalanceUpdate.AddField("Username", GlobalVariables.username);
                    BalanceUpdate.AddField("Balance", Convert.ToString(GlobalVariables.balance));


                   // WWW www = new WWW("https://dominikw.de/AzubiProjekt/UpdateBalance.php", BalanceUpdate);
                   WWW www = new WWW("https://dominikw.de/AzubiProjekt/UpdateBalanceDEV.php", BalanceUpdate);
                   // WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/UpdateBalanceDEV.php", BalanceUpdate);
                    yield return www;
                    //Debug.Log(www.text);
                    Debug.Log("Event Kapital updated");
                    break;
                }
            case 1:
                {
                    Debug.Log("Alte Balance" + GlobalVariables.balance);
                    GlobalVariables.balance = GlobalVariables.balance + value;
                    Debug.Log("Neue Balance" + GlobalVariables.balance);
                    WWWForm BalanceUpdate = new WWWForm();
                    BalanceUpdate.AddField( "Username", GlobalVariables.username);
                    BalanceUpdate.AddField("Balance", Convert.ToString(GlobalVariables.balance));


                    // WWW www = new WWW("https://dominikw.de/AzubiProjekt/UpdateBalance.php", BalanceUpdate);
                     WWW www = new WWW("https://dominikw.de/AzubiProjekt/UpdateBalanceDEV.php", BalanceUpdate);
                    // www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/UpdateBalanceDEV.php", BalanceUpdate);
                    yield return www;
                   // Debug.Log(www.text);
                   // Debug.Log("Event Kapital updated");
                    break;
                }
        }
        
    }

    IEnumerator ExecuteKunden(int value, int vorzeichen)
    {
        Debug.Log("In execute Kunde:"+GlobalVariables.kundenanzahl+"vorzeichen "+vorzeichen);
        switch (vorzeichen)
        {
            case 0:
                {
                   
                    //Debug.Log("Alte Balance" + GlobalVariables.balance);
                    if (GlobalVariables.kundenanzahl - value > 0)
                    {
                        GlobalVariables.kundenanzahl = GlobalVariables.kundenanzahl - value;
                    }
                    else
                    {
                        GlobalVariables.kundenanzahl = 5;
                    }
                    
                    Debug.Log("kunden" + GlobalVariables.kundenanzahl);
                    // Debug.Log("Neue Balance" + GlobalVariables.balance);
                    WWWForm BalanceUpdate = new WWWForm();
                    BalanceUpdate.AddField("Username", GlobalVariables.username);
                    BalanceUpdate.AddField( "anzahl", Convert.ToString(GlobalVariables.kundenanzahl));


                    WWW www = new WWW("https://dominikw.de/AzubiProjekt/UpdateKundeDEV.php", BalanceUpdate);
                    yield return www;
                    //Debug.Log(www.text);
                    Debug.Log("Event kUNDE updated");
                    break;
                    
                }
            case 1:
                {
                    // Debug.Log("Alte Balance" + GlobalVariables.balance);
                    GlobalVariables.kundenanzahl = GlobalVariables.kundenanzahl + value;
                    //Debug.Log("Neue Balance" + GlobalVariables.balance);
                    WWWForm BalanceUpdate = new WWWForm();
                    BalanceUpdate.AddField("Username", GlobalVariables.username);
                    BalanceUpdate.AddField("anzahl", Convert.ToString(GlobalVariables.kundenanzahl));


                    // WWW www = new WWW("https://dominikw.de/AzubiProjekt/UpdateBalance.php", BalanceUpdate);
                     WWW www = new WWW("https://dominikw.de/AzubiProjekt/UpdateKundeDEV.php", BalanceUpdate);
                   
                    yield return www;
                    // Debug.Log(www.text);
                     Debug.Log("Event Kunde updated");
                    break;
                }
        }
    }


}
