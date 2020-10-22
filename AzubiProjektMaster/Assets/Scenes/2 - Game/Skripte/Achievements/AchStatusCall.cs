// Author: Justin Edelmann
// Co-Author: Colin Schmoll & Thorge Siemens
// Script um die Achievements aus der Datenbank zu lesen und gemäß Datenbankabfrage die Anzahl der erreichten
// Achievements auf der GUI für den jeweiligen User freizuschalten

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class AchStatusCall : MonoBehaviour
{
    // Verlinkung der TMP´s in Unity mit dem Skript
    public TextMeshProUGUI Ach1;
    public TextMeshProUGUI Ach2;
    public TextMeshProUGUI Ach3;
    public TextMeshProUGUI Ach4;
    public TextMeshProUGUI Ach5;
    public TextMeshProUGUI Ach6;
    public TextMeshProUGUI Ach7;
    public TextMeshProUGUI Ach8;
    public TextMeshProUGUI Ach9;

    // <sprite=1> => Grauer Coin
    // <sprite=0> => Goldener Coin
    private void Start()
    {
        // Auffüllen aller Achievements mit grauen Coins
        Ach1.text = "<sprite=1>";
        Ach2.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach3.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach4.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach5.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach6.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach7.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach8.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach9.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        // Aufruf, alle Achievement-Methoden jede 5 Sekunden aufzurufen (update) 
        // InvokeRepeating(string methodName, float startTime, float repeatRate);
        InvokeRepeating("Ach1Exe", 0.5f, 5.0f); 
        InvokeRepeating("Ach2Exe", 0.5f, 5.0f);
        InvokeRepeating("Ach3Exe", 0.5f, 5.0f);
        InvokeRepeating("Ach4Exe", 0.5f, 5.0f);
        InvokeRepeating("Ach5Exe", 0.5f, 5.0f);
        InvokeRepeating("Ach6Exe", 0.5f, 5.0f);
        InvokeRepeating("Ach7Exe", 0.5f, 5.0f);
        InvokeRepeating("Ach8Exe", 0.5f, 5.0f);
        InvokeRepeating("Ach9Exe", 0.5f, 5.0f);
    }
    /* Ach1 = absolviere das Tutorial
     * Ach2 = Erreiche ein maximal Kapital von
     * Ach3 = Stelle x Mitarbeiter ein
     * Ach4 = Anzahl x Kunden
     * Ach5 = Kaufe x Filialen
     * Ach6 = Vergebe x Kredite
     * Ach7 = Entlasse keine Mitarbeiter für x Tage
     * Ach8 = Verdiene x mit Aktienhandel
     * Ach9 = Upragade das IT Gebäude 5 mal
     */

    //Achievement "absolviere das Tutorial": Anfang
    int achievement1;
    public void Ach1Exe()
    {
        StartCoroutine(ExecuteAch1());
    }
    IEnumerator ExecuteAch1()
    {
        yield return StartCoroutine(DatenLesenAch1());
        AusgabeAch1();
    }
    IEnumerator DatenLesenAch1()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);
        WWW www = new WWW("http://localhost/Test/AchievementItLesen.php", form);
        yield return www;
        string achievement1Db = www.text.Split()[0];
        achievement1 = Convert.ToInt32(achievement1Db);
    }
    public void AusgabeAch1()
    {
        if (achievement1 == 0)
        {
            Ach1.text = "<sprite=1>";
        }
        else
        {
            Ach1.text = "<sprite=0>";
        }
    }
    //Achievement "absolviere das Tutorial":  Ende
    //-------------------------------------


    //Achievement "Erreiche ein maximal Kapital von": Anfang
    int achievement2;
    public void Ach2Exe()
    {
        StartCoroutine(ExecuteAch2());
    }
    IEnumerator ExecuteAch2()
    {
        yield return StartCoroutine(DatenLesenAch2());
        AusgabeAch2();
    }
    IEnumerator DatenLesenAch2()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);
        WWW www = new WWW("http://localhost/Test/AchievementItLesen.php", form);
        yield return www;
        string achievement2Db = www.text.Split()[0];
        achievement2 = Convert.ToInt32(achievement2Db);
    }
    public void AusgabeAch2()
    {
        if (achievement2 == 0)
        {
            Ach2.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement2 == 1)
        {
            Ach2.text = "<sprite=0> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement2 == 2)
        {
            Ach2.text = "<sprite=0> <sprite=0> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement2 == 3)
        {
            Ach2.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=1> <sprite=1>";
        }
        else if (achievement2 == 4)
        {
            Ach2.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=1>";
        }
        else if (achievement2 == 5)
        {
            Ach2.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=0>";
        }
    }
    //Achievement "Erreiche ein maximal Kapital von":  Ende
    //-------------------------------------

    //Achievement "Stelle x Mitarbeiter ein": Anfang
    int achievement3;
    public void Ach3Exe()
    {
        StartCoroutine(ExecuteAch3());
    }
    IEnumerator ExecuteAch3()
    {
        yield return StartCoroutine(DatenLesenAch3());
        AusgabeAch3();
    }
    IEnumerator DatenLesenAch3()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);
        WWW www = new WWW("http://localhost/Test/AchievementItLesen.php", form);
        yield return www;
        string achievement3Db = www.text.Split()[0];
        achievement3 = Convert.ToInt32(achievement3Db);
    }
    public void AusgabeAch3()
    {
        if (achievement3 == 0)
        {
            Ach3.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement3 == 1)
        {
            Ach3.text = "<sprite=0> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement3 == 2)
        {
            Ach3.text = "<sprite=0> <sprite=0> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement3 == 3)
        {
            Ach3.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=1> <sprite=1>";
        }
        else if (achievement3 == 4)
        {
            Ach3.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=1>";
        }
        else if (achievement3 == 5)
        {
            Ach3.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=0>";
        }
    }
    //Achievement "Stelle x Mitarbeiter ein":  Ende
    //-------------------------------------


    //Achievement "Anzahl x Kunden": Anfang
    int achievement4;
    public void Ach4Exe()
    {
        StartCoroutine(ExecuteAch4());
    }
    IEnumerator ExecuteAch4()
    {
        yield return StartCoroutine(DatenLesenAch4());
        AusgabeAch4();
    }
    IEnumerator DatenLesenAch4()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);
        WWW www = new WWW("http://localhost/Test/AchievementItLesen.php", form);
        yield return www;
        string achievement4Db = www.text.Split()[0];
        achievement4 = Convert.ToInt32(achievement4Db);
    }
    public void AusgabeAch4()
    {
        if (achievement4 == 0)
        {
            Ach4.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement4 == 1)
        {
            Ach4.text = "<sprite=0> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement4 == 2)
        {
            Ach4.text = "<sprite=0> <sprite=0> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement4 == 3)
        {
            Ach4.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=1> <sprite=1>";
        }
        else if (achievement4 == 4)
        {
            Ach4.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=1>";
        }
        else if (achievement4 == 5)
        {
            Ach4.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=0>";
        }
    }
    //Achievement "Anzahl x Kunden":  Ende
    //-------------------------------------


    //Achievement "Kaufe x Filialen": Anfang
    int achievement5;
    public void Ach5Exe()
    {
        StartCoroutine(ExecuteAch5());
    }
    IEnumerator ExecuteAch5()
    {
        yield return StartCoroutine(DatenLesenAch5());
        AusgabeAch5();
    }
    IEnumerator DatenLesenAch5()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);
        WWW www = new WWW("http://localhost/Test/AchievementItLesen.php", form);
        yield return www;
        string achievement5Db = www.text.Split()[0];
        achievement5 = Convert.ToInt32(achievement5Db);
    }
    public void AusgabeAch5()
    {
        if (achievement5 == 0)
        {
            Ach5.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement5 == 1)
        {
            Ach5.text = "<sprite=0> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement5 == 2)
        {
            Ach5.text = "<sprite=0> <sprite=0> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement5 == 3)
        {
            Ach5.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=1> <sprite=1>";
        }
        else if (achievement5 == 4)
        {
            Ach5.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=1>";
        }
        else if (achievement5 == 5)
        {
            Ach5.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=0>";
        }
    }
    //Achievement "Kaufe x Filialen":  Ende
    //-------------------------------------


    //Achievement "Vergebe x Kredite": Anfang
    int achievement6;
    public void Ach6Exe()
    {
        StartCoroutine(ExecuteAch6());
    }
    IEnumerator ExecuteAch6()
    {
        yield return StartCoroutine(DatenLesenAch6());
        AusgabeAch6();
    }
    IEnumerator DatenLesenAch6()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);
        WWW www = new WWW("http://localhost/Test/AchievementItLesen.php", form);
        yield return www;
        string achievement6Db = www.text.Split()[0];
        achievement6 = Convert.ToInt32(achievement6Db);
    }
    public void AusgabeAch6()
    {
        if (achievement6 == 0)
        {
            Ach6.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement6 == 1)
        {
            Ach6.text = "<sprite=0> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement6 == 2)
        {
            Ach6.text = "<sprite=0> <sprite=0> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement6 == 3)
        {
            Ach6.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=1> <sprite=1>";
        }
        else if (achievement6 == 4)
        {
            Ach6.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=1>";
        }
        else if (achievement6 == 5)
        {
            Ach6.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=0>";
        }
    }
    //Achievement "Vergebe x Kredite":  Ende
    //-------------------------------------


    //Achievement "Entlasse keine Mitarbeiter für x Tage": Anfang
    int achievement7;
    public void Ach7Exe()
    {
        StartCoroutine(ExecuteAch7());
    }
    IEnumerator ExecuteAch7()
    {
        yield return StartCoroutine(DatenLesenAch7());
        AusgabeAch7();
    }
    IEnumerator DatenLesenAch7()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);
        WWW www = new WWW("http://localhost/Test/AchievementItLesen.php", form);
        yield return www;
        string achievement7Db = www.text.Split()[0];
        achievement7 = Convert.ToInt32(achievement7Db);
    }
    public void AusgabeAch7()
    {
        if (achievement7 == 0)
        {
            Ach7.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement7 == 1)
        {
            Ach7.text = "<sprite=0> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement7== 2)
        {
            Ach7.text = "<sprite=0> <sprite=0> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement7 == 3)
        {
            Ach7.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=1> <sprite=1>";
        }
        else if (achievement7 == 4)
        {
            Ach7.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=1>";
        }
        else if (achievement7 == 5)
        {
            Ach7.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=0>";
        }
    }
    //Achievement "Entlasse keine Mitarbeiter für x Tage":  Ende
    //-------------------------------------


    //Achievement "Verdiene x mit Aktienhandel": Anfang
    int achievement8;
    public void Ach8Exe()
    {
        StartCoroutine(ExecuteAch8());
    }
    IEnumerator ExecuteAch8()
    {
        yield return StartCoroutine(DatenLesenAch8());
        AusgabeAch8();
    }
    IEnumerator DatenLesenAch8()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);
        WWW www = new WWW("http://localhost/Test/AchievementItLesen.php", form);
        yield return www;
        string achievement8Db = www.text.Split()[0];
        achievement8 = Convert.ToInt32(achievement8Db);
    }
    public void AusgabeAch8()
    {
        if (achievement8 == 0)
        {
            Ach8.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement8 == 1)
        {
            Ach8.text = "<sprite=0> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement8 == 2)
        {
            Ach8.text = "<sprite=0> <sprite=0> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement8 == 3)
        {
            Ach8.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=1> <sprite=1>";
        }
        else if (achievement8 == 4)
        {
            Ach8.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=1>";
        }
        else if (achievement8 == 5)
        {
            Ach8.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=0>";
        }
    }
    //Achievement "Verdiene x mit Aktienhandel":  Ende
    //-------------------------------------


    //Achievement "Upragade das IT Gebäude 5 mal":  Anfang
    int achievement9;
    public void Ach9Exe()
    {
        StartCoroutine(ExecuteAch9());
    }
    IEnumerator ExecuteAch9()
    {
        yield return StartCoroutine(DatenLesenAch9());
        AusgabeAch9();
    }
    IEnumerator DatenLesenAch9()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);
        WWW www = new WWW("http://localhost/Test/AchievementItLesen.php", form);
        yield return www;
        string achievement9Db = www.text.Split()[0];
        achievement1 = Convert.ToInt32(achievement9Db);   
    }
    public void AusgabeAch9()
    {
        if (achievement9 == 0)
        {
            Ach9.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement9 == 1)
        {
            Ach9.text = "<sprite=0> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement9 == 2)
        {
            Ach9.text = "<sprite=0> <sprite=0> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement9 == 3)
        {
            Ach9.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=1> <sprite=1>";
        }
        else if (achievement9 == 4)
        {
            Ach9.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=1>";
        }
        else if (achievement9 == 5)
        {
            Ach9.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=0>";
        }
    }
    //Achievement "Upragade das IT Gebäude 5 mal":  Ende
    //-------------------------------------
}