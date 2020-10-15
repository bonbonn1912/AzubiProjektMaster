using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    // public Text ausgabeZeit;
    public DailyUpdate ausfuhren;
    public TagUpdaten erhoehen;
    public Kreditlaufzeit pruefen;
    


    public AktienKurseGenerieren Aktie1;
    public AktienKurseGenerieren Aktie2;
    public AktienKurseGenerieren Aktie3;
    public AktienKurseGenerieren Aktie4;
    public AktienKurseGenerieren Aktie5;
   
    public AktienKurseLesen AktienKurs1;
    public AktienKurseLesen AktienKurs2;

    public AktienAnzahlAbfragen Abfragen;

    public TriggerEvents Event;
    
    public int day = GlobalVariables.day;
    private int month = 1;
    private int year = 1;
    private float timePassed = 0;
    private float timeCounter;
    private int x = 0;
    public int DayInSeconds = 5;
    int gametimelocal;
    public void Start()
    {
        /*if (GlobalVariables.username == null)
        {
            GlobalVariables.username = "SebastianTest1";
        }*/

        ausfuhren.Init();
    }
    public void Awake()
    {
        /*if (GlobalVariables.username == null)
        {
            GlobalVariables.username = "SebastianTest1";
        }*/
        Abfragen.getAktienAnzahl();
        //  GenerateValues();
        SetTutorialTrigger();

    }

    public void GenerateValues()
    {
        StartCoroutine(GenerateAktienKurse());
    }

    public void SetTutorialTrigger()
    {
        StartCoroutine(SetTutorialIETrue());
    }

    IEnumerator GenerateAktienKurse()
    {
        yield return new WaitForSeconds(0.5f);
        if (DailyUpdate.check == 0)
        {
            for (int i = 0; i < 100; i++)
            {
                Aktie1.KursAktie1();
                Aktie2.KursAktie2();
                Aktie3.KursAktie3();
                Aktie4.KursAktie4();
                Aktie5.KursAktie5();
              
            }
        }
        
        yield return new WaitForSeconds(0.5f);
     // StartCoroutine(SetTutorialTrue());
    }



    IEnumerator SetTutorialIETrue()
    {
        Debug.Log("wait 3 seconds");
        yield return new WaitForSeconds(3);
        Debug.Log("3 seconds over");
        WWWForm Tutorial = new WWWForm();
        Tutorial.AddField("username", GlobalVariables.username);
        // WWW update = new WWW("https://dominikw.de/AzubiProjekt/UpdateTutorial.php", Tutorial);
       // WWW update = new WWW("https://dominikw.de/AzubiProjekt/UpdateTutorialDEV.php", Tutorial);
        WWW update = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/UpdateTutorialDEV.php", Tutorial);
        yield return update;
        Debug.Log("tutorial true");
    }
    private void Update() 
    {

        gametimelocal = FigurPopUp.GameTimeGlob;
        timeCounter = Time.time - timePassed;

        //die Zahl in if-Bedingung ist Tageslänge in Sekunden
          if (timeCounter > gametimelocal) 
          {
              timePassed += timeCounter;
            GlobalVariables.day = GlobalVariables.day + 1;
            // Debug.Log(GlobalVariables.day);
            DailyMethoden();
            if (GlobalVariables.day % 10 == 0)
            {
               Event.TriggerCo();
               // Debug.Log("Monate zu Ende");
            }
           
        }




        /*  if(timeCounter = DayInSeconds/4 ){
         *  toggle.Kursgenerieren();
          }*/
        
       
    }
    public void DailyMethoden()
    {
        //  public DailyUpdate ausfuhren;
     // public TagUpdaten erhoehen;
     //   public Kreditlaufzeit pruefen;
    // Debug.Log("Global day" + GlobalVariables.day);
    ausfuhren.execute();
        ausfuhren.GetBuildingStats();
       // erhoehen.TagErhoehen();
        Aktie1.KursAktie1();
        Aktie2.KursAktie2();
        Aktie3.KursAktie3();
        Aktie4.KursAktie4();
        Aktie5.KursAktie5();

      //  AktienKurs1.LesenAktie1();
        pruefen.LautZeitVeringern();
    }

     
    
}
