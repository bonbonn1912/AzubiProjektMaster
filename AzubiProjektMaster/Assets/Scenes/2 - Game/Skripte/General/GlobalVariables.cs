﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVariables : MonoBehaviour
{
    
    public static string username;
    public static int day;
    public static int PID;
    public static string registrationResult = null;


    public static bool LoggedIn { get { return username != null; } }

    public static void LogOut()
    {
        username = null;
    }

    public static bool Tutorialcheck;
    public static int startkapital = 50000;
    public static int mitarbeiterStart = 20;
    public static int PersonalCost = 4000;
    public static int buildingsStart = 0;
   
    public static int mitarbeiter;
    public static int balance;
    public static int minDuration = 20;
    public static int maxDuration = 100;
    public static int Mitarbeitergewinn = 5000;

    public static int Aktie1KursGlob;
    public static int Aktie2KursGlob;
    public static int Aktie3KursGlob;
    public static int Aktie4KursGlob;
    public static int Aktie5KursGlob;

    public static int AktienIndex = 250;

    public static int itStatus;
    public static int hrStatus;
    public static int dwsStatus;
    public static int inStatus;
    public static int ausStatus;


    //Achievements
    public static int Aktien;
    public static int anzahlKredite;
    public static int anzahlKunden;

    public static int Tutorial;
    public static int mitarbeiterAlt;
    public static int entlassungZaehler;

    public static int achievementAktien;
    public static int achievementEntlassen;
    public static int achievementFilialen;
    public static int achievementHr;
    public static int achievementIt;
    public static int achievementKapital;
    public static int achievementKredite;
    public static int achievementKunden;
    public static int achievementTutorial;

    public static int aAktien;
    public static int bAktien;
    public static int cAktien;
    public static int dAktien;
    public static int eAktien;

    public static int aEntlassen;
    public static int bEntlassen;
    public static int cEntlassen;
    public static int dEntlassen;
    public static int eEntlassen;

    public static int aFilialen;
    public static int bFilialen;
    public static int cFilialen;
    public static int dFilialen;
    public static int eFilialen;

    public static int aHr;
    public static int bHr;
    public static int cHr;
    public static int dHr;
    public static int eHr;

    public static int aIt;
    public static int bIt;
    public static int cIt;
    public static int dIt;
    public static int eIt;

    public static int aKapital;
    public static int bKapital;
    public static int cKapital;
    public static int dKapital;
    public static int eKapital;

    public static int aKredite;
    public static int bKredite;
    public static int cKredite;
    public static int dKredite;
    public static int eKredite;

    public static int aKunden;
    public static int bKunden;
    public static int cKunden;
    public static int dKunden;
    public static int eKunden;

    public static int aTutorial;
}
