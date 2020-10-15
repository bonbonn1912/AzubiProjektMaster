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
    public int Value;
   
    public void TriggerDecision()
    {
        int a = Random.Range(1, 12);

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
                    int b = generateNegativeAuswirkung();
                    Headline.GetComponent<Text>().text = "Immer mehr Mitarbeiter erkranken";
                    Body.GetComponent<Text>().text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, " +
                        "sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. " +
                        "At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus " +
                        "est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod " +
                        "tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo " +
                        "dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";
                    Auswirkung.GetComponent<Text>().text =  "Dies kostet dich: " + b + "€";
                    TriggerEvent(b, 0);
                    break;
                }
            case 2:
                {
                    int b = generateNegativeAuswirkung();
                    Headline.GetComponent<Text>().text = "Hacker dringen in das Banknetz ein";
                    Body.GetComponent<Text>().text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, " +
                        "sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. " +
                        "At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus " +
                        "est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod " +
                        "tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo " +
                        "dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";
                    Auswirkung.GetComponent<Text>().text = "Dies kostet dich: " + b + "€";
                    TriggerEvent(b, 0);
                    break;
                }
            case 3:
                {
                    int b = generateNegativeAuswirkung();
                    Headline.GetComponent<Text>().text = "Erneute Kurseverluste für die Bank";
                    Body.GetComponent<Text>().text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, " +
                        "sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. " +
                        "At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus " +
                        "est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod " +
                        "tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo " +
                        "dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";
                    Auswirkung.GetComponent<Text>().text = "Dies kostet dich: " + b + "€";
                    TriggerEvent(b, 0);
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
                    int b = generateNeutraleAuswirkung();
                    Headline.GetComponent<Text>().text = "Die Bank lädt zur Jahreshauptversammlung ein!";
                    Body.GetComponent<Text>().text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, " +
                        "sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. " +
                        "At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus " +
                        "est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod " +
                        "tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo " +
                        "dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";
                    Auswirkung.GetComponent<Text>().text = "Dies bringt dir: " + b + "€";
                   StartCoroutine(Execute(b, 1));
                    break;
                }
            case 5:
                {
                    int b = generateNeutraleAuswirkung();
                    Headline.GetComponent<Text>().text = "Der neue James Bond wird in deiner Stadt gedreht!";
                    Body.GetComponent<Text>().text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, " +
                        "sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. " +
                        "At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus " +
                        "est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod " +
                        "tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo " +
                        "dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";
                    Auswirkung.GetComponent<Text>().text = "Dies bringt dir: " + b + "€";
                    StartCoroutine(Execute(b, 1));
                    break;
                }
            case 6:
                {
                    int b = generateNeutraleAuswirkung();
                    Headline.GetComponent<Text>().text = "Deine Stadt hat die zufriedensten Einwohner im Land";
                    Body.GetComponent<Text>().text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, " +
                        "sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. " +
                        "At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus " +
                        "est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod " +
                        "tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo " +
                        "dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";
                    Auswirkung.GetComponent<Text>().text = "Dies bringt dir: " + b + "€";
                     StartCoroutine(Execute(b, 1));
                    break;
                }
            case 7:
                {
                    int b = generateNeutraleAuswirkung();
                    Headline.GetComponent<Text>().text = "Ein Bundesligist ist zum Trainingslager in deiner Stadt";
                    Body.GetComponent<Text>().text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, " +
                        "sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. " +
                        "At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus " +
                        "est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod " +
                        "tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo " +
                        "dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";
                    Auswirkung.GetComponent<Text>().text = "Dies bringt dir: " + b + "€";
                     StartCoroutine(Execute(b, 1));
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
                    Headline.GetComponent<Text>().text = "Massive Kursgewinne für die Aktien der Bank";
                    Body.GetComponent<Text>().text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, " +
                        "sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. " +
                        "At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus " +
                        "est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod " +
                        "tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo " +
                        "dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";
                    Auswirkung.GetComponent<Text>().text = "Dies bringt dir: " + b + "€";
                     StartCoroutine(Execute(b, 1));
                    break;
                }
            case 9:
                {
                    int b = generatePositiveAuswirkung();
                    Headline.GetComponent<Text>().text = "Höchste Anzahl an Bewerbungen seit 20 Jahren!";
                    Body.GetComponent<Text>().text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, " +
                        "sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. " +
                        "At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus " +
                        "est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod " +
                        "tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo " +
                        "dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";
                    Auswirkung.GetComponent<Text>().text = "Dies bringt dir: " + b + "€";
                     StartCoroutine(Execute(b, 1));
                    break;
                }
            case 10:
                {
                    int b = generatePositiveAuswirkung();
                    Headline.GetComponent<Text>().text = "Alle Aktien der Finanzbranche steigen";
                    Body.GetComponent<Text>().text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, " +
                        "sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. " +
                        "At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus " +
                        "est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod " +
                        "tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo " +
                        "dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";
                    Auswirkung.GetComponent<Text>().text = "Dies bringt dir: " + b + "€";
                   StartCoroutine(Execute(b, 1));
                    break;
                }
            case 11:
                {
                    int b = generatePositiveAuswirkung();
                    Headline.GetComponent<Text>().text = "Deine Bank verkündet die Zusammenarbeit mit einem Tech-Giganten";
                    Body.GetComponent<Text>().text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, " +
                        "sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. " +
                        "At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus " +
                        "est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod " +
                        "tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo " +
                        "dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";
                    Auswirkung.GetComponent<Text>().text = "Dies bringt dir: " + b + "€";
                     StartCoroutine(Execute(b, 1));
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
                    Auswirkung.GetComponent<Text>().text = "Dies bringt dir: " + b + "€";
                  StartCoroutine(Execute(b, 1));
                    break;
                }

        }
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

    IEnumerator Execute(int value, int vorzeichen)
    {
        Debug.Log("in coroutine");
         yield return new WaitForSeconds(1.5f);
        switch (vorzeichen)
        {
            case 0:
                {
                    Debug.Log("Alte Balance" + GlobalVariables.balance);
                    GlobalVariables.balance = GlobalVariables.balance - value;
                    Debug.Log("Neue Balance" + GlobalVariables.balance);
                    WWWForm BalanceUpdate = new WWWForm();
                    BalanceUpdate.AddField(GlobalVariables.username, "Username");
                    BalanceUpdate.AddField(Convert.ToString(GlobalVariables.balance), "Balance");


                   // WWW www = new WWW("https://dominikw.de/AzubiProjekt/UpdateBalance.php", BalanceUpdate);
                    WWW www = new WWW("https://dominikw.de/AzubiProjekt/UpdateBalanceDEV.php", BalanceUpdate);
                    yield return www;
                    Debug.Log(www.text);
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
                    yield return www;
                    Debug.Log(www.text);
                    Debug.Log("Event Kapital updated");
                    break;
                }
        }
        
    }




}
