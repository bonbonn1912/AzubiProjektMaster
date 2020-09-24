using System;
using System.Collections;
using System.Collections.Generic;
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


    private int day = GlobalVariables.day;
    private int month = 1;
    private int year = 1;
    private float timePassed = 0;
    private float timeCounter;
    private int x = 0;
    public int DayInSeconds = 5;
    
    private void Update() 
    {
        timeCounter = Time.time - timePassed;

        //die Zahl in if-Bedingung ist Tageslänge in Sekunden
          if (timeCounter > 2) 
          {
              timePassed += timeCounter;
              day++;
              GlobalVariables.day = day;
             // Debug.Log(day);
            ausfuhren.execute();
            erhoehen.TagErhoehen();
            Aktie1.KursAktie1();
            Aktie2.KursAktie2();
            Aktie3.KursAktie3();
            Aktie4.KursAktie4();
            Aktie5.KursAktie5();
            pruefen.LautZeitVeringern();
          }



        /*  if(timeCounter = DayInSeconds/4 ){
         *  toggle.Kursgenerieren();
          }*/
        
       
    }
}
