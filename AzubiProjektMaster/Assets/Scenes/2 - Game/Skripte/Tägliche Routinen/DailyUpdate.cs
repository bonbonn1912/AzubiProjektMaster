using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class DailyUpdate : MonoBehaviour
{
    public static int check = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //test
    public void execute()
    {
     //   Debug.Log("Coroutine wird gestartet");
        StartCoroutine(StatusBarUpdate());
    }

    public void Init()
    {

        StartCoroutine(Initco());
        StartCoroutine(GetBuildingsCo());

        //Achievements
        GetAchievementAktien();
        Aktien.Errungenschaften();
        SetAchievementsAktien();

        GetAchievementEntlassen();
        Entlassen.Errungenschaften();
        Entlassen.Zaehler();
        SetAchievementsEntlassen();

        GetAchievementFilialen();
        Filialen.Errungenschaften();
        SetAchievementsFilialen();

        GetAchievementHR();
        HR.Errungenschaften();
        SetAchievementsHR();

        GetAchievementIT();
        IT.Errungenschaften();
        SetAchievementsIT();

        GetAchievementKapital();
        Kapital.Errungenschaften();
        SetAchievementsKapital();

        GetAchievementKredite();
        Kredite.Errungenschaften();
        SetAchievementsKredite();

        GetAchievementKunden();
        Kunden.Errungenschaften();
        SetAchievementsKunden();

        GetAchievementTutorial();
        Tutorial.Errungenschaften();
        SetAchievementsTutorial();
    }
    public void GetBuildingStats()
    {
        StartCoroutine(GetBuildingsCo());
    }
    public void SetBuildingStats()
    {
        StartCoroutine(SetBuildingsCo());
    }
    IEnumerator StatusBarUpdate()
    {
        if(GlobalVariables.day % 30 == 0)
        {
            GlobalVariables.balance = GlobalVariables.balance - GlobalVariables.mitarbeiter * GlobalVariables.PersonalCost;
            GlobalVariables.balance = GlobalVariables.balance + GlobalVariables.mitarbeiter * GlobalVariables.Mitarbeitergewinn;
            Debug.Log("PersonalKosten: " + GlobalVariables.mitarbeiter * GlobalVariables.PersonalCost);
            Debug.Log("PersonalGewinn: " + GlobalVariables.mitarbeiter * GlobalVariables.Mitarbeitergewinn);
            WWWForm form1 = new WWWForm();
            form1.AddField("Username", GlobalVariables.username);
            form1.AddField("Balance", GlobalVariables.balance);
            WWW www1 = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/UpdateKreditBalance.php", form1);
            Debug.Log("Kosten abgezogen");
            yield return www1;
            yield return new WaitForSeconds(0.2f);
            Debug.Log("Kapital nach Gehalt" + GlobalVariables.balance);
        }

      //  Debug.Log("Routine getriggert");
        WWWForm form = new WWWForm();
        form.AddField("username", GlobalVariables.username);
        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/statusbarupdate.php", form);
        yield return www;
        Debug.Log("Daily statusbarupdate "+www.text);
        string[] results = www.text.Split('-');


        GlobalVariables.PID = Convert.ToInt32(results[0]);
        GlobalVariables.balance = Convert.ToInt32(results[1]);
        GlobalVariables.day = Convert.ToInt32(results[2]);
     //   Debug.Log("globale variable nach zuweisung " + GlobalVariables.day);
        GlobalVariables.mitarbeiter = Convert.ToInt32(results[3]);
       // Debug.Log(GlobalVariables.PID);

      //  Debug.Log("Balance: " + GlobalVariables.balance);
      //  Debug.Log("Spieltage: " + GlobalVariables.day);
     //   Debug.Log("Mitarbeiter aus DatenBank: " + GlobalVariables.mitarbeiter);


    }

    IEnumerator Initco()
    {
       // Debug.Log("in init");
        WWWForm form = new WWWForm();
        form.AddField("username", GlobalVariables.username);
        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/statusbarupdate.php", form);
        yield return www;
        Debug.Log("Init datenbank "+www.text);
        string[] results = www.text.Split('-');


        GlobalVariables.PID = Convert.ToInt32(results[0]);
        GlobalVariables.balance = Convert.ToInt32(results[1]);
        GlobalVariables.day = Convert.ToInt32(results[2]);
        GlobalVariables.mitarbeiter = Convert.ToInt32(results[3]);
         check = Convert.ToInt32(results[4]);
        if (check == 1)
        {
            GlobalVariables.Tutorialcheck = true;
            FigurPopUp.GameTimeGlob = 3;
        } 
        else if(check == 0)
        {
           GlobalVariables.Tutorialcheck = false;
            FigurPopUp.GameTimeGlob = 1000;

        }

        // Debug.Log(GlobalVariables.Tutorialcheck);

        //  Debug.Log("Balance: " + GlobalVariables.balance);
        //  Debug.Log("Spieltage: " + GlobalVariables.day);
        // Debug.Log("Mitarbeiter aus DatenBank: " + GlobalVariables.mitarbeiter);
    }
    IEnumerator GetBuildingsCo()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", GlobalVariables.username);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/buildingStatusLesen.php", form);
        yield return www;
        string[] results = www.text.Split('-'); //0=BID,1=IT,2=HR,3=DWS,4=InlandFil,5=AuslandFil
        Debug.Log("Buildings result: " + www.text);
        GlobalVariables.itStatus = Convert.ToInt32(results[1]);
        GlobalVariables.hrStatus = Convert.ToInt32(results[2]);
        GlobalVariables.dwsStatus = Convert.ToInt32(results[3]);
        GlobalVariables.inStatus = Convert.ToInt32(results[4]);
        GlobalVariables.ausStatus = Convert.ToInt32(results[5]);
    }
    IEnumerator SetBuildingsCo()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", GlobalVariables.username);
        form.AddField("it", GlobalVariables.itStatus);
        form.AddField("hr", GlobalVariables.hrStatus);
        form.AddField("dws", GlobalVariables.dwsStatus);
        form.AddField("inland", GlobalVariables.inStatus);
        form.AddField("ausland", GlobalVariables.ausStatus);
        form.AddField("balance", GlobalVariables.balance);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/buildingStatusSchreiben.php", form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("Successfull building Update");
        }
        else
        {
            Debug.Log("building Update: " + www.text);
        }
    }


    //Aktien werden über Aktienfenster aktualisiert und nicht täglich. Code ist in AktienAnzahlAbfragen.cs mit speichern in GlobalVariables.Aktien
    IEnumerator GetAchievementAktien()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/AchievementAktienLesen.php", form); //PHP-Skript unvollständig, da nicht klar ist, wo Gewinn aus Aktien liegt
        yield return www;

        string aktienDb = www.text.Split('-')[0];
        string aDb = www.text.Split('-')[1];
        string bDb = www.text.Split('-')[2];
        string cDb = www.text.Split('-')[3];
        string dDb = www.text.Split('-')[4];
        string eDb = www.text.Split('-')[5];
        string achievementDb = www.text.Split('-')[6];

        GlobalVariables.Aktien = Convert.ToInt32(aktienDb);
        GlobalVariables.aAktien = Convert.ToInt32(aDb);
        GlobalVariables.bAktien = Convert.ToInt32(bDb);
        GlobalVariables.cAktien = Convert.ToInt32(cDb);
        GlobalVariables.dAktien = Convert.ToInt32(dDb);
        GlobalVariables.eAktien = Convert.ToInt32(eDb);
        GlobalVariables.achievementAktien = Convert.ToInt32(achievementDb);
    }

    IEnumerator SetAchievementsAktien()
    {
        string x = Convert.ToString(GlobalVariables.achievementAktien);
        string aDb = Convert.ToString(GlobalVariables.aAktien);
        string bDb = Convert.ToString(GlobalVariables.bAktien);
        string cDb = Convert.ToString(GlobalVariables.cAktien);
        string dDb = Convert.ToString(GlobalVariables.dAktien);
        string eDb = Convert.ToString(GlobalVariables.eAktien);
        string aktienDb = Convert.ToString(GlobalVariables.Aktien);

        WWWForm form = new WWWForm();
        form.AddField("AchievementShares", x);
        form.AddField("user", GlobalVariables.username);
        form.AddField("Wert1", aDb);
        form.AddField("Wert2", bDb);
        form.AddField("Wert3", cDb);
        form.AddField("Wert4", dDb);
        form.AddField("Wert5", eDb);
        form.AddField("Anzahl", aktienDb);


        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/AchievementAktienSchreiben.php", form); //PHP-Skript unvollständig, da nicht klar ist, wo Gewinn aus Aktien liegt
        yield return www;
    }

    IEnumerator GetAchievementEntlassen()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte//DwsKaufen.php", form);
        yield return www;

        string aDb = www.text.Split('-')[0];
        string bDb = www.text.Split('-')[1];
        string cDb = www.text.Split('-')[2];
        string dDb = www.text.Split('-')[3];
        string eDb = www.text.Split('-')[4];
        string achievementDb = www.text.Split('-')[5];
        string entZaehlerDB = www.text.Split('-')[6];

        GlobalVariables.aEntlassen = Convert.ToInt32(aDb);
        GlobalVariables.bEntlassen = Convert.ToInt32(bDb);
        GlobalVariables.cEntlassen = Convert.ToInt32(cDb);
        GlobalVariables.dEntlassen = Convert.ToInt32(dDb);
        GlobalVariables.eEntlassen = Convert.ToInt32(eDb);
        GlobalVariables.achievementEntlassen = Convert.ToInt32(achievementDb);
        GlobalVariables.entlassungZaehler = Convert.ToInt32(entZaehlerDB);
    }

    IEnumerator SetAchievementsEntlassen()
    {
        string x = Convert.ToString(GlobalVariables.achievementEntlassen);
        string aDb = Convert.ToString(GlobalVariables.aEntlassen);
        string bDb = Convert.ToString(GlobalVariables.bEntlassen);
        string cDb = Convert.ToString(GlobalVariables.cEntlassen);
        string dDb = Convert.ToString(GlobalVariables.dEntlassen);
        string eDb = Convert.ToString(GlobalVariables.eEntlassen);
        string entZaehlerDb = Convert.ToString(GlobalVariables.entlassungZaehler);


        WWWForm form = new WWWForm();
        form.AddField("AchievementEntlassung", x);
        form.AddField("user", GlobalVariables.username);
        form.AddField("Wert1", aDb);
        form.AddField("Wert2", bDb);
        form.AddField("Wert3", cDb);
        form.AddField("Wert4", dDb);
        form.AddField("Wert5", eDb);
        form.AddField("Zaehler", entZaehlerDb);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/DwsSchreiben.php", form);
        yield return www;
    }

    IEnumerator GetAchievementFilialen()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/DwsKaufen.php", form);
        yield return www;

        string filialenDb = www.text.Split('-')[0];
        string aDb = www.text.Split('-')[1];
        string bDb = www.text.Split('-')[2];
        string cDb = www.text.Split('-')[3];
        string dDb = www.text.Split('-')[4];
        string eDb = www.text.Split('-')[5];
        string achievementDb = www.text.Split('-')[6];

        GlobalVariables.inStatus = Convert.ToInt32(filialenDb);
        GlobalVariables.aFilialen = Convert.ToInt32(aDb);
        GlobalVariables.bFilialen = Convert.ToInt32(bDb);
        GlobalVariables.cFilialen = Convert.ToInt32(cDb);
        GlobalVariables.dFilialen = Convert.ToInt32(dDb);
        GlobalVariables.eFilialen = Convert.ToInt32(eDb);
        GlobalVariables.achievementFilialen = Convert.ToInt32(achievementDb);
    }

    IEnumerator SetAchievementsFilialen()
    {
        string x = Convert.ToString(GlobalVariables.achievementFilialen);
        string aDb = Convert.ToString(GlobalVariables.aFilialen);
        string bDb = Convert.ToString(GlobalVariables.bFilialen);
        string cDb = Convert.ToString(GlobalVariables.cFilialen);
        string dDb = Convert.ToString(GlobalVariables.dFilialen);
        string eDb = Convert.ToString(GlobalVariables.eFilialen);

        WWWForm form = new WWWForm();
        form.AddField("AchievementHR", x);
        form.AddField("user", GlobalVariables.username);
        form.AddField("Wert1", aDb);
        form.AddField("Wert2", bDb);
        form.AddField("Wert3", cDb);
        form.AddField("Wert4", dDb);
        form.AddField("Wert5", eDb);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/DwsSchreiben.php", form);
        yield return www;

    }

    IEnumerator GetAchievementHR()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/AchievementHrLesen.php", form);
        yield return www;


        string angestellteDb = www.text.Split('-')[0];
        string aDb = www.text.Split('-')[1];
        string bDb = www.text.Split('-')[2];
        string cDb = www.text.Split('-')[3];
        string dDb = www.text.Split('-')[4];
        string eDb = www.text.Split('-')[5];
        string achievementDb = www.text.Split('-')[6];

        GlobalVariables.mitarbeiter = Convert.ToInt32(angestellteDb);
        GlobalVariables.aHr = Convert.ToInt32(aDb);
        GlobalVariables.bHr = Convert.ToInt32(bDb);
        GlobalVariables.cHr = Convert.ToInt32(cDb);
        GlobalVariables.dHr = Convert.ToInt32(dDb);
        GlobalVariables.eHr = Convert.ToInt32(eDb);
        GlobalVariables.achievementHr = Convert.ToInt32(achievementDb);
    }

    IEnumerator SetAchievementsHR()
    {
        string x = Convert.ToString(GlobalVariables.achievementHr);
        string aDb = Convert.ToString(GlobalVariables.aHr);
        string bDb = Convert.ToString(GlobalVariables.bHr);
        string cDb = Convert.ToString(GlobalVariables.cHr);
        string dDb = Convert.ToString(GlobalVariables.dHr);
        string eDb = Convert.ToString(GlobalVariables.eHr);


        WWWForm form = new WWWForm();
        form.AddField("AchievementHR", x);
        form.AddField("user", GlobalVariables.username);
        form.AddField("Wert1", aDb);
        form.AddField("Wert2", bDb);
        form.AddField("Wert3", cDb);
        form.AddField("Wert4", dDb);
        form.AddField("Wert5", eDb);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/AchievementHrSchreiben.php", form);
        yield return www;
    }

    IEnumerator GetAchievementIT()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/AchievementItLesen.php", form);
        yield return www;

        string itDb = www.text.Split('-')[0];
        string aDb = www.text.Split('-')[1];
        string bDb = www.text.Split('-')[2];
        string cDb = www.text.Split('-')[3];
        string dDb = www.text.Split('-')[4];
        string eDb = www.text.Split('-')[5];
        string achievementDb = www.text.Split('-')[6];

        GlobalVariables.itStatus = Convert.ToInt32(itDb);
        GlobalVariables.aIt = Convert.ToInt32(aDb);
        GlobalVariables.bIt = Convert.ToInt32(bDb);
        GlobalVariables.cIt = Convert.ToInt32(cDb);
        GlobalVariables.dIt = Convert.ToInt32(dDb);
        GlobalVariables.eIt = Convert.ToInt32(eDb);
        GlobalVariables.achievementIt = Convert.ToInt32(achievementDb);
    }

    IEnumerator SetAchievementsIT()
    {
        string x = Convert.ToString(GlobalVariables.achievementIt);
        string aDb = Convert.ToString(GlobalVariables.aIt);
        string bDb = Convert.ToString(GlobalVariables.bIt);
        string cDb = Convert.ToString(GlobalVariables.cIt);
        string dDb = Convert.ToString(GlobalVariables.dIt);
        string eDb = Convert.ToString(GlobalVariables.eIt);


        WWWForm form = new WWWForm();
        form.AddField("AchievementIT", x);
        form.AddField("user", GlobalVariables.username);
        form.AddField("Wert1", aDb);
        form.AddField("Wert2", bDb);
        form.AddField("Wert3", cDb);
        form.AddField("Wert4", dDb);
        form.AddField("Wert5", eDb);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/AchievementItSchreiben.php", form);
        yield return www;
    }

    IEnumerator GetAchievementKapital()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/Test/DwsKaufen.php", form);
        yield return www;

        string kapitalDb = www.text.Split('-')[0];
        string aDb = www.text.Split('-')[1];
        string bDb = www.text.Split('-')[2];
        string cDb = www.text.Split('-')[3];
        string dDb = www.text.Split('-')[4];
        string eDb = www.text.Split('-')[5];
        string achievementDb = www.text.Split('-')[6];

        GlobalVariables.balance = Convert.ToInt32(kapitalDb);
        GlobalVariables.aKapital = Convert.ToInt32(aDb);
        GlobalVariables.bKapital = Convert.ToInt32(bDb);
        GlobalVariables.cKapital = Convert.ToInt32(cDb);
        GlobalVariables.dKapital = Convert.ToInt32(dDb);
        GlobalVariables.eKapital = Convert.ToInt32(eDb);
        GlobalVariables.achievementKapital = Convert.ToInt32(achievementDb);
    }

    IEnumerator SetAchievementsKapital()
    {
        string x = Convert.ToString(GlobalVariables.achievementKapital);
        string aDb = Convert.ToString(GlobalVariables.aKapital);
        string bDb = Convert.ToString(GlobalVariables.bKapital);
        string cDb = Convert.ToString(GlobalVariables.cKapital);
        string dDb = Convert.ToString(GlobalVariables.dKapital);
        string eDb = Convert.ToString(GlobalVariables.eKapital);


        WWWForm form = new WWWForm();
        form.AddField("AchievementMoney", x);
        form.AddField("user", GlobalVariables.username);
        form.AddField("Wert1", aDb);
        form.AddField("Wert2", bDb);
        form.AddField("Wert3", cDb);
        form.AddField("Wert4", dDb);
        form.AddField("Wert5", eDb);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/DwsSchreiben.php", form);
        yield return www;
    }

    IEnumerator GetAchievementKredite()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/DwsKaufen.php", form);
        yield return www;

        string krediteDb = www.text.Split('-')[0];
        string aDb = www.text.Split('-')[1];
        string bDb = www.text.Split('-')[2];
        string cDb = www.text.Split('-')[3];
        string dDb = www.text.Split('-')[4];
        string eDb = www.text.Split('-')[5];
        string achievementDb = www.text.Split('-')[6];

        GlobalVariables .anzahlKredite = Convert.ToInt32(krediteDb);
        GlobalVariables.aKredite = Convert.ToInt32(aDb);
        GlobalVariables.bKredite = Convert.ToInt32(bDb);
        GlobalVariables.cKredite = Convert.ToInt32(cDb);
        GlobalVariables.dKredite = Convert.ToInt32(dDb);
        GlobalVariables.eKredite = Convert.ToInt32(eDb);
        GlobalVariables.achievementKredite = Convert.ToInt32(achievementDb);
    }

    IEnumerator SetAchievementsKredite()
    {
        string x = Convert.ToString(GlobalVariables.achievementKredite);
        string aDb = Convert.ToString(GlobalVariables.aKredite);
        string bDb = Convert.ToString(GlobalVariables.bKredite);
        string cDb = Convert.ToString(GlobalVariables.cKredite);
        string dDb = Convert.ToString(GlobalVariables.dKredite);
        string eDb = Convert.ToString(GlobalVariables.eKredite);
        string krediteDb = Convert.ToString(GlobalVariables.anzahlKredite);


        WWWForm form = new WWWForm();
        form.AddField("AchievementCredit", x);
        form.AddField("user", GlobalVariables.username);
        form.AddField("Wert1", aDb);
        form.AddField("Wert2", bDb);
        form.AddField("Wert3", cDb);
        form.AddField("Wert4", dDb);
        form.AddField("Wert5", eDb);
        form.AddField("Anzahl", krediteDb);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/DwsSchreiben.php", form);
        yield return www;
    }

    IEnumerator GetAchievementKunden()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/DwsKaufen.php", form);
        yield return www;

        string kundenDb = www.text.Split('-')[0];
        string aDb = www.text.Split('-')[1];
        string bDb = www.text.Split('-')[2];
        string cDb = www.text.Split('-')[3];
        string dDb = www.text.Split('-')[4];
        string eDb = www.text.Split('-')[5];
        string achievementDb = www.text.Split('-')[6];

        GlobalVariables.anzahlKunden = Convert.ToInt32(kundenDb);
        GlobalVariables.aKunden = Convert.ToInt32(aDb);
        GlobalVariables.bKunden = Convert.ToInt32(bDb);
        GlobalVariables.cKunden = Convert.ToInt32(cDb);
        GlobalVariables.dKunden = Convert.ToInt32(dDb);
        GlobalVariables.eKunden = Convert.ToInt32(eDb);
        GlobalVariables.achievementKunden = Convert.ToInt32(achievementDb);
    }

    IEnumerator SetAchievementsKunden()
    {
        string x = Convert.ToString(GlobalVariables.achievementKunden);
        string aDb = Convert.ToString(GlobalVariables.aKunden);
        string bDb = Convert.ToString(GlobalVariables.bKunden);
        string cDb = Convert.ToString(GlobalVariables.cKunden);
        string dDb = Convert.ToString(GlobalVariables.dKunden);
        string eDb = Convert.ToString(GlobalVariables.eKunden);


        WWWForm form = new WWWForm();
        form.AddField("AchievementCustomers", x);
        form.AddField("user", GlobalVariables.username);
        form.AddField("Wert1", aDb);
        form.AddField("Wert2", bDb);
        form.AddField("Wert3", cDb);
        form.AddField("Wert4", dDb);
        form.AddField("Wert5", eDb);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/DwsSchreiben.php", form);
        yield return www;
    }

    IEnumerator GetAchievementTutorial()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/DwsKaufen.php", form);
        yield return www;

        string tutorialDb = www.text.Split('-')[0];
        string aDb = www.text.Split('-')[1];
        string achievementDb = www.text.Split('-')[6];

        GlobalVariables.Tutorial = Convert.ToInt32(tutorialDb);
        GlobalVariables.aTutorial = Convert.ToInt32(aDb);
        GlobalVariables.achievementTutorial = Convert.ToInt32(achievementDb);
    }

    IEnumerator SetAchievementsTutorial()
    {
        string x = Convert.ToString(GlobalVariables.achievementTutorial);
        string aDb = Convert.ToString(GlobalVariables.aTutorial);


        WWWForm form = new WWWForm();
        form.AddField("AchievementTutorial", x);
        form.AddField("user", GlobalVariables.username);
        form.AddField("Wert1", aDb);

        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/DwsSchreiben.php", form);
        yield return www;
    }


}
