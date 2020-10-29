using System;
using System.Collections;
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
    public GameObject figurHandler;
    public Text Willkommenstext;
    public Text Einführungstext;
    public Text Zieletext;
    public Text Huerdentext;
    public Text Filialetext;
    public Text ITtext;
    public Text HRtext;
    public Text DWStext;
    public Text Starttext;

    private bool speechActive;
    private bool skip;
    private int active;

    private string InhaltWill = "Herzlich Willkommen! Sie haben Ihre eigene Bank eröffnet! Sie sind der neue CEO " + GlobalVariables.username + " der " + GlobalVariables.Bankname + ". Ein bisschen Trivia: Im Jahre 1870 wurde die Deutsche Bank gegründet.";
    private string InhaltEin = "Ihr Ziel ist es, die Bank voranzubringen und zu expandieren. Im Spielverlauf werden Sie einige neue Gebäude, Finanzmittel und die Story kennenlernen. Treffen Sie ihre Entscheidungen mit Bedacht.";
    private string InhaltZiele = "Mal schauen ob Sie das Zeug dazuhaben, alle Achievements zu erreichen und ihre Zentrale auf Stufe 5 hochzustufen.";
    private string InhaltHuerden = "Am Anfang befinden Sie sich in der Finanzierungsphase: Wie wollen Sie Ihr Geld verdienen? Sie müssen einiges beachten, es gibt Risiken, Krisen, Sicherheitslücken und vieles mehr. Finden Sie ihr eigenes Gleichgewicht.";
    private string InhaltFiliale = "Für den Anfang besitzen Sie ihre Zentrale mit 4 Mitarbeitern, in welcher Sie ihre Einnahmen und Ausgaben im Überblick behalten und ihre vergebene Kredite beobachten können.";
    private string InhaltIT = "Das IT Gebäude können Sie erwerben, wenn Sie 2 Filialen besitzen. Dies erhöht die Erträge der Mitarbeiter.";
    private string InhaltHR = "Das HR Gebäude können Sie erwerben, wenn sie 4 Filialen besitzen. Durch das Einstellen und Entlassen der Mitarbeiter fallen jeweils Kosten an.";
    private string InhaltDWS = "Die DWS können Sie nach erwerb von 3 Filialen freischalten. Hier können Sie Aktien kaufen, verkaufen und sie verwalten. Sie haben eine Echtzeitansicht der Aktienkurse.";
    private string InhaltStart = "Legen wir los! Ihre ersten Kredite sind nicht weit entfernt. Viel Erfolg und viel Spaß!";

    public float timeLapse = 0.03f;
    public static int GameTimeGlob = 15;

    public void OnClick()
    {
        if (speechActive)
        {
            skip = true;
        }
        else
        {
            switch (active)
            {
                case 0:
                    FigurUntenRechtsErscheinen();
                    break;
                case 1:
                    FigurMitteErscheinen();
                    break;
                case 2:
                    SprechBlaseHürdenAnzeigen();
                    break;
                case 3:
                    FigurFilialeErscheinen();
                    break;
                case 4:
                    FigurITErscheinen();
                    break;
                case 5:
                    FigurHRErscheinen();
                    break;
                case 6:
                    FigurDWSErscheinen();
                    break;
                case 7:
                    FigurSpielstartErscheinen();
                    break;
                case 8:
                    TutorialCheckTrueSetzen();
                    break;
                default:
                    break;
            }
        }
    }
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
            if (figurHandler != null)
            {
                figurHandler.SetActive(!figurHandler.activeSelf);
            }
            if (FigurUL != null)
            {
                active = 0;
                bool isActive = FigurUL.activeSelf;
                FigurUL.SetActive(!isActive);
                StartCoroutine(SpeechbubblGenerate(Willkommenstext, InhaltWill, 0));
            }
        }
    }

    //Verzögert das erscheinen jedes Buchstaben in der Sprechblase für die vorgefertigten Strings
    IEnumerator SpeechbubblGenerate(Text Inputext, String Inhalt, int Ende)
    {
        speechActive = true;
        skip = false;
        if (Ende == 1)
        {
            WWWForm form = new WWWForm();
            form.AddField("username", GlobalVariables.username);
            WWW www = new WWW("https://dominikw.de/AzubiProjekt/UpdateBuildingsDEV.php", form);
            yield return www;
            Debug.Log("Gebäude wurden geupdatet : " + www.text);

            GlobalVariables.itStatus = 0;
            GlobalVariables.hrStatus = 0;
            GlobalVariables.dwsStatus = 0;
        }
        for (int i = 0; i < Inhalt.Length; i++)
        {
            Inputext.text = string.Concat(Inputext.text, Inhalt[i]);
            //Warte eine bestimmte Zeit und starte den Loop erneut
            if (!skip)
            {
                yield return new WaitForSeconds(timeLapse);
            }
        }
        speechActive = false;
    }

    //aktiviert Figur Unten Rechts
    public void FigurUntenRechtsErscheinen()
    {
        if (FigurUL != null)
        {
            bool isActive = FigurUL.activeSelf;
            FigurUL.SetActive(!isActive);
        }

        if (FigurUR != null)
        {
            active = 1;
            bool isActive = FigurUR.activeSelf;
            FigurUR.SetActive(!isActive);
            StartCoroutine(SpeechbubblGenerate(Einführungstext, InhaltEin, 0));
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
            active = 2;
            bool isActive = FigurMid.activeSelf;
            FigurMid.SetActive(!isActive);
            StartCoroutine(SpeechbubblGenerate(Zieletext, InhaltZiele, 0));
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
            active = 3;
            bool isActive = SprechblaseHürden.activeSelf;
            SprechblaseHürden.SetActive(!isActive);
            StartCoroutine(SpeechbubblGenerate(Huerdentext, InhaltHuerden, 0));
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
            active = 4;
            bool isActive = FigurFiliale.activeSelf;
            FigurFiliale.SetActive(!isActive);
            CameraZoom.ZoomActiveT1 = true;
            StartCoroutine(SpeechbubblGenerate(Filialetext, InhaltFiliale, 0));
        }
    }

    //aktiviert Figur am IT Gebäude
    public void FigurITErscheinen()
    {
        if (FigurFiliale != null)
        {
            CameraZoom.ZoomActiveT1 = false;
            CameraZoom.Zoom = 110;
            bool isActive = FigurFiliale.activeSelf;
            FigurFiliale.SetActive(!isActive);
        }

        if (FigurIT != null)
        {
            active = 5;
            bool isActive = FigurIT.activeSelf;
            FigurIT.SetActive(!isActive);
            CameraZoom.ZoomActiveT2 = true;
            StartCoroutine(SpeechbubblGenerate(ITtext, InhaltIT, 0));
        }
    }

    //aktiviert Figur am HR Gebäude
    public void FigurHRErscheinen()
    {
        if (FigurIT != null)
        {
            CameraZoom.ZoomActiveT1 = false;
            CameraZoom.Zoom = 80;
            bool isActive = FigurIT.activeSelf;
            FigurIT.SetActive(!isActive);
        }

        if (FigurHR != null)
        {
            active = 6;
            bool isActive = FigurHR.activeSelf;
            FigurHR.SetActive(!isActive);
            CameraZoom.ZoomActiveT3 = true;
            StartCoroutine(SpeechbubblGenerate(HRtext, InhaltHR, 0));
        }
    }

    //aktiviert Figur am DWS Gebäude
    public void FigurDWSErscheinen()
    {
        if (FigurHR != null)
        {
            CameraZoom.ZoomActiveT3 = false;
            CameraZoom.Zoom = 120;
            bool isActive = FigurHR.activeSelf;
            FigurHR.SetActive(!isActive);
        }

        if (FigurDWS != null)
        {
            active = 7;
            bool isActive = FigurDWS.activeSelf;
            FigurDWS.SetActive(!isActive);
            CameraZoom.ZoomActiveT4 = true;
            StartCoroutine(SpeechbubblGenerate(DWStext, InhaltDWS, 0));
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
            active = 8;
            bool isActive = FigurSpielstart.activeSelf;
            FigurSpielstart.SetActive(!isActive);
            StartCoroutine(SpeechbubblGenerate(Starttext, InhaltStart, 1));
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
            if (figurHandler != null)
            {
                figurHandler.SetActive(false);
            }
        }
    }
}