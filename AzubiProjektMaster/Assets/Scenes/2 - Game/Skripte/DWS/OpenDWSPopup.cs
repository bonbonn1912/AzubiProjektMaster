using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDWSPopup : MonoBehaviour
{
    public GameObject DWSPanel;
    public GameObject Bloomberg;
    public GameObject kaufenApp;


    public GameObject InputFieldAktie1;
    public GameObject TextAktie1;
    public GameObject InputFieldAktie2;
    public GameObject TextAktie2;
    public GameObject InputFieldAktie3;
    public GameObject TextAktie3;
    public GameObject InputFieldAktie4;
    public GameObject TextAktie4;
    public GameObject InputFieldAktie5;
    public GameObject TextAktie5;

    public GameObject MasterText;

    public DailyUpdate dailyUp;

    public Text ausgabe;

    int Filialen = 3;


    public void OpenPanel()
    {
        Debug.Log("triggered");
        //Debug.Log("Open Panel");
        if (GlobalVariables.dwsStatus == 0)
        {
            bool appAktive = kaufenApp.activeSelf;
            kaufenApp.SetActive(!appAktive);
        }
        else if (GlobalVariables.dwsStatus == 1)
        {
            if (DWSPanel != null && Bloomberg != null)
            {
                bool bloomActive = Bloomberg.activeSelf;
                Bloomberg.SetActive(!bloomActive);
                bool isActive = DWSPanel.activeSelf;
                DWSPanel.SetActive(!isActive);
            }
            InputFieldAktie1.GetComponent<InputField>().text = "";
            InputFieldAktie2.GetComponent<InputField>().text = "";
            InputFieldAktie3.GetComponent<InputField>().text = "";
            InputFieldAktie4.GetComponent<InputField>().text = "";
            InputFieldAktie5.GetComponent<InputField>().text = "";

            TextAktie1.GetComponent<Text>().text = "";
            TextAktie2.GetComponent<Text>().text = "";
            TextAktie3.GetComponent<Text>().text = "";
            TextAktie4.GetComponent<Text>().text = "";
            TextAktie5.GetComponent<Text>().text = "";
        }
    }
    public void Kaufen()
    {
        // Abfrage ob Bedingungen erfüllt sind
        if (Filialen >= 3)
        {
            if (GlobalVariables.balance > 1000)
            {
                GlobalVariables.balance = GlobalVariables.balance - 1000;
                GlobalVariables.dwsStatus = 1;
                //Coroutine Update DWS level + Geld
                dailyUp.SetBuildingStats();
                kaufenApp.SetActive(false);
            }
            else
            {
                FehlerGeld();
            }
        }
        else
        {
            FehlerBedingung();
        }
    }

    //Fehlermeldungen müssen evtl noch angepasst werden bzgl Ausgabe im Spiel selber
    public void FehlerGeld()
    {
        Debug.Log("Du hast nicht genug Geld");
    }
    public void FehlerBedingung()
    {
        Debug.Log("Du hast nicht genug Filialen");
    }
}
