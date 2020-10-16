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
    public Text Willkommenstext;
    public Text Einführungstext;
    public Text Zieletext;
    public Text Huerdentext;
    public Text Filialetext;
    public Text ITtext;
    public Text HRtext;
    public Text DWStext;
    public Text Starttext;
    


    private string InhaltWill = "Herzlich Willkommen! Sie haben Ihre eigene Bank eröffnet! Sie sind der neue CEO " + GlobalVariables.username + " der " + GlobalVariables.Bankname + ". Ein bisschen Trivia: 1870 war die Gründung von der Deutschen Bank.";
    private string InhaltEin = "Vergewissern Sie sich dass Sie ihre Bank voranbringen wollen und sie nicht in den Bankrott treiben. Sie werden im Spielverlauf einige neue Gebäude, Finanzmittel und die Story kennen lernen. Sie entscheiden, was Sie wollen!";
    private string InhaltZiele = "Mal schauen ob Sie das Zeug dazuhaben alle Achievements zu finden und ihre Hauptzentrale auf Stufe 5 zu bekommen.";
    private string InhaltHuerden = "Am Anfang befinden Sie sich in der Finanzierungsphase, wie wollen Sie Ihr Geld verdienen.Sie müssen einiges beachten, es gibt wie überall Risiken, Krisen, Sicherheitslücken, uvm. Finden Sie ihr eigenes Gleichgewicht";
    private string InhaltFiliale = "Für den Anfang besitzen Sie ihre Zentrale mit 4 Mitarbeitern, wo Ihre Einnahmen und Ausgaben im Überblick haben und ihre Kredite sehen können.";
    private string InhaltIT = "Das IT Gebäude können Sie nach 2 Filialen kaufen und dies erhöht Ihre Erträge der Mitarbeiter.";
    private string InhaltHR = "Das HR Gebäude können Sie nach 4 Filialen freischalten und hier stellen Sie Mitarbeiter ein und entlassen sie, was jeweils Geld kostet.";
    private string InhaltDWS = "Die DWS können Sie nach erwerb von 3 Filialen freischalten. Hier können Sie Ihre Aktien kaufen, verkaufen und verwalten. Sie haben eine echtzeit Ansicht der Kurse, wählen Sie mit bedacht einen Zeitpunkt zum Kaufen und Verkaufen.";
    private string InhaltStart = "Legen wir los! Ihre ersten Kredite sind nicht weit entfernt. Viel Erfolg und viel Spaß!";

    public float timeLapse = 0.03f;
    public static int GameTimeGlob = 15;


    //Lässt den ersten Charakter erscheinen, wenn Tutorial noch nicht absolviert wurde
    void Start()
    {
        StartAblauf();
       
    }
    
    //startet Coroutine Verzögern
    public void StartAblauf()
    {
        StartCoroutine(Verzoegern());
    }
    
    //Numerator zum verzögern der ersten Sprechblase
    IEnumerator Verzoegern()
    {
        yield return new WaitForSeconds(0.5f);
        openPanel();
    }
    
    //Aktiviert das erste Männchen mit Sprechblase
    public void openPanel()
    {
        //Debug.Log(DailyUpdate.check);
        if (GlobalVariables.Tutorialcheck != true)
        {
            if (FigurUL != null)
            {

                bool isActive = FigurUL.activeSelf;
                FigurUL.SetActive(!isActive);
                StartCoroutine(SpeechbubblGenerate(Willkommenstext, InhaltWill));
            }
        }
    }

    //Verzögert das erscheinen jedes Buchstaben in der Sprechblase für die vorgefertigten Strings
    IEnumerator SpeechbubblGenerate(Text Inputext, String Inhalt)
    {
        for (int i = 0; i < Inhalt.Length; i++)
        {
           Inputext.text = string.Concat(Inputext.text, Inhalt[i]);
            //Warte eine bestimmte Zeit und starte den Loop erneut
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
            StartCoroutine(SpeechbubblGenerate(Einführungstext, InhaltEin));
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
            StartCoroutine(SpeechbubblGenerate(Zieletext, InhaltZiele));
        }
    }
    
    //Lässt Sprechblase für Hürden erscheinen.
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
            StartCoroutine(SpeechbubblGenerate(Huerdentext, InhaltHuerden));
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
            StartCoroutine(SpeechbubblGenerate(Filialetext, InhaltFiliale));
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
            StartCoroutine(SpeechbubblGenerate(ITtext, InhaltIT));
        }
    }

    //aktiviert Figur am HR Gebäude
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
            StartCoroutine(SpeechbubblGenerate(HRtext, InhaltHR));
        }
    }

    //aktiviert Figur am DWS Gebäude
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
            StartCoroutine(SpeechbubblGenerate(DWStext, InhaltDWS));
        }
    }

    //aktiviert Figur in der Mitte(Spielstart)
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
            StartCoroutine(SpeechbubblGenerate(Starttext, InhaltStart));
        }
    }

    //Setzt die Bool in der Datenbank auf True, damit das Tutorial nicht erneut ausgefüht wird. 
    public void TutorialCheckTrueSetzen()
    {
       
        if (FigurSpielstart != null)
        {
            bool isActive = FigurSpielstart.activeSelf;
            FigurSpielstart.SetActive(!isActive);
            GlobalVariables.Tutorialcheck = true;
           
            CameraZoom.ZoomActiveT4 = false;
            GameTimeGlob = 15;
        }
        
    }

    

  


}





