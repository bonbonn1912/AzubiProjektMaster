using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;

public class FigurPopUp : MonoBehaviour
{
    
    public GameObject FigurUL;
    public GameObject FigurMid;
    public GameObject FigurUR;
    public GameObject FigurHR;
    public GameObject FigurFiliale;
    public GameObject FigurIT;
    public GameObject FigurDWS;
    public GameObject FigurSpielstart;
    public GameObject SprechblaseHürden;
    public GameObject SprechblaseZiele;
    public Text Speechbubble1;
    public float timeLapse = 0.03f;
    public string Bubble1 = "Hallo " + GlobalVariables.username + " einfügen,dich sehe ja zum ersten mal hier.Ich glaube es ist besser wenn ich dir die wichtisten Gebäude in der Stadt und ihre funktionen zeige. Klick auf mich um fortzufahren";
    
    //Lässt den ersten Charakter erscheinne, wenn Tutorial noch nicht absolviert wurde
    void Start()
    {
        StartAblauf();
       
    }

    public void StartAblauf()
    {
        StartCoroutine(Verzoegern());
    }

    IEnumerator Verzoegern()
    {
        yield return new WaitForSeconds(0.5f);
        openPanel();
    }
    public void openPanel()
    {
        Debug.Log(DailyUpdate.check);
        if (GlobalVariables.Tutorialcheck != true)
        {
            if (FigurUL != null)
            {

                bool isActive = FigurUL.activeSelf;
                FigurUL.SetActive(!isActive);
                StartCoroutine(SpeechbubblGenerate());
            }
        }
    }

    IEnumerator SpeechbubblGenerate()
    {
        for (int i = 0; i < Bubble1.Length; i++)
        {
            Speechbubble1.text = string.Concat(Speechbubble1.text, Bubble1[i]);
            //Wait a certain amount of time, then continue with the for loop
            yield return new WaitForSeconds(timeLapse);
        }
    }

   //aktiviert Figur Unten Rechts
    public void FigurUntenRechtserscheinen()
    {
         if (FigurUL != null)
         {
             bool isActive = FigurUL.activeSelf;
             FigurUL.SetActive(!isActive);

        }

        if (FigurUR != null)
        {
            bool isActive = FigurUR.activeSelf;
            FigurUR.SetActive(!isActive);
        }
    }

    //aktiviert Figur Mitte
    public void FigurMitteErscheinen()
    {
        if (FigurUR != null)
        {
            bool isActive = FigurUR.activeSelf;
            FigurUR.SetActive(!isActive);

        }

        if (FigurMid != null)
        {
            bool isActive = FigurMid.activeSelf;
            FigurMid.SetActive(!isActive);
        }
    }

    //aktiviert Figur am Filiale Gebäude
    public void FigurFilialeErscheinen()
    {

        if (FigurMid != null)
        {
            bool isActive = FigurMid.activeSelf;
            FigurMid.SetActive(!isActive);
        }

        if (FigurFiliale != null)
        {
            bool isActive = FigurFiliale.activeSelf;
            FigurFiliale.SetActive(!isActive);
            CameraZoom.ZoomActiveT1 = true;
        }
    }

    //aktiviert Figur am IT Gebäude
    public void FigurITErscheinen()
    {
        if (FigurFiliale != null)
        {
            CameraZoom.ZoomActiveT1 = false;
            bool isActive = FigurFiliale.activeSelf;
            FigurFiliale.SetActive(!isActive);
        }

        if (FigurIT != null)
        {
            bool isActive = FigurIT.activeSelf;
            FigurIT.SetActive(!isActive);
            CameraZoom.ZoomActiveT2 = true;
        }
    }

    public void FigurHRErscheinen()
    {
        if (FigurIT != null)
        {
            CameraZoom.ZoomActiveT1 = false;
            bool isActive = FigurIT.activeSelf;
            FigurIT.SetActive(!isActive);
            
        }

        if (FigurHR != null)
        {
            bool isActive = FigurHR.activeSelf;
            FigurHR.SetActive(!isActive);
            CameraZoom.ZoomActiveT3 = true;
        }
    }

    public void FigurDWSErscheinen()
    {
        if (FigurHR != null)
        {
            CameraZoom.ZoomActiveT3 = false;
            bool isActive = FigurHR.activeSelf;
            FigurHR.SetActive(!isActive);

        }

        if (FigurDWS != null)
        {
            bool isActive = FigurDWS.activeSelf;
            FigurDWS.SetActive(!isActive);
            CameraZoom.ZoomActiveT4 = true;
        }
    }

    public void FigurSpielstartErscheinen()
    {
        if (FigurDWS != null)
        {
            CameraZoom.ZoomActiveT4 = false;
            CameraZoom.ZoomActiveT0 = true;
            CameraZoom.Zoom = 190;
            bool isActive = FigurDWS.activeSelf;
            FigurDWS.SetActive(!isActive);

        }

        if (FigurSpielstart != null)
        {
            bool isActive = FigurSpielstart.activeSelf;
            FigurSpielstart.SetActive(!isActive);            
        }
    }

    public void TutorialCheckTrueSetzen()
    {
       
        if (FigurSpielstart != null)
        {
            bool isActive = FigurSpielstart.activeSelf;
            FigurSpielstart.SetActive(!isActive);
            GlobalVariables.Tutorialcheck = true;
            CameraZoom.ZoomActiveT4 = false;
            
        }
        
    }

    public void SprechBlaseHürdenAnzeigen()
    {
        if (SprechblaseZiele != null)
        {
            bool isActive = SprechblaseZiele.activeSelf;
            SprechblaseZiele.SetActive(!isActive);
        }

        if (SprechblaseHürden != null)
        {
            bool isActive = SprechblaseHürden.activeSelf;
            SprechblaseHürden.SetActive(!isActive);
        }
    }


}





