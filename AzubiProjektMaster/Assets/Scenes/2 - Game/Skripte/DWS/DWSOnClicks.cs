﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DWSOnClicks : MonoBehaviour
{
    public GameObject kaufenApp;
    public GameObject dwsAktienPopUp;
    public GameObject bloombergPopUp;
    public GameObject graphTablet;
    public GameObject aktienTablet;
    public GameObject AktienHandelPopupText;
    public GameObject graphPopUpText;

    public GameObject orderVolumenDynamischDefault;
    public Color DepotInhaberTextboxColor;
    public Text DepotInhaberTextbox;

    public DailyUpdate dailyUp;

    int Filialen = 3;
    

    public void DWSOnClick()
    {
        if (GlobalVariables.dwsStatus == 0)
        {
            kaufenApp.SetActive(!kaufenApp.activeSelf);
        }
        else if (GlobalVariables.dwsStatus == 1)
        {
            if (dwsAktienPopUp != null && bloombergPopUp != null)
            {
                bloombergPopUp.SetActive(!bloombergPopUp.activeSelf);
                dwsAktienPopUp.SetActive(!dwsAktienPopUp.activeSelf);
            } 
        }
    }
    public void OpenGraphTablet()
    {
        graphTablet.SetActive(!graphTablet.activeSelf);
        MainScene.TabletHandlerActivate();
    }
    public void OpenAktienTablet()
    {
        if (aktienTablet != null)
        {
            aktienTablet.SetActive(!aktienTablet.activeSelf);
            DepotInhaberTextbox.text = GlobalVariables.username;
            MainScene.TabletHandlerActivate();
        }
    }
    public void AktienPopUpHover()
    {
        if (AktienHandelPopupText != null)
        {
            AktienHandelPopupText.SetActive(!AktienHandelPopupText.activeSelf);
        }
    }

    public void GraphPopUpHover()
    {
        if (graphPopUpText != null)
        {
            graphPopUpText.SetActive(!graphPopUpText.activeSelf);
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
