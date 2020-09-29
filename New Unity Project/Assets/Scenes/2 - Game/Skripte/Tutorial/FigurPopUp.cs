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
    public Text Speechbubble1;
    public float timeLapse = 0.03f;
    public string Bubble1 = "Hallo /global username/ einfügen,dich sehe ja zum ersten mal hier.Ich glaube es ist besser wenn ich dir die wichtisten Gebäude in der Stadt und ihre funktionen zeige. Klick auf mich um fortzufahren";
    void Start()
    {
        
        if(GlobalVariables.Tutorialcheck != true)
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

    public void FigurHRErscheinen()
    {

        if (FigurMid != null)
        {
            bool isActive = FigurMid.activeSelf;
            FigurMid.SetActive(!isActive);
        }

        if (FigurHR != null)
        {
            bool isActive = FigurHR.activeSelf;
            FigurHR.SetActive(!isActive);
        }
    }
}


