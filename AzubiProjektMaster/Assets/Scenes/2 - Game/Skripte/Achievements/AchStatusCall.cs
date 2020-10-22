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
        Ach1.text = "<sprite=1>";
        Ach2.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach3.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach4.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach5.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach6.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach7.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach8.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach9.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        InvokeRepeating("AchUpdate1", 5.0f, 5.0f); 
        InvokeRepeating("AchUpdateIT", 5.0f, 5.0f);
        InvokeRepeating("AchUpdate3", 5.0f, 5.0f);
        InvokeRepeating("AchUpdate4", 5.0f, 5.0f);
        InvokeRepeating("AchUpdate5", 5.0f, 5.0f);
        InvokeRepeating("AchUpdate6", 5.0f, 5.0f);
        InvokeRepeating("AchUpdate7", 5.0f, 5.0f);
        InvokeRepeating("AchUpdate8", 5.0f, 5.0f);
        InvokeRepeating("AchUpdate9", 5.0f, 5.0f);
    }
    /* Ach1 =
     * Ach2 =
     * Ach3 = 
     * Ach4 = 
     * Ach5 =
     * Ach6 =
     * Ach7 =
     * Ach8 =
     * Ach9 =
     */



    //Achievement "absolviere das Tutorial": Anfang

    //Achievement "absolviere das Tutorial":  Ende
    //-------------------------------------


    //Achievement "Erreiche ein maximal Kapital von": Anfang

    //Achievement "Erreiche ein maximal Kapital von":  Ende
    //-------------------------------------

    //Achievement "Stelle x Mitarbeiter ein  ": Anfang

    //Achievement "Stelle x Mitarbeiter ein  ":  Ende
    //-------------------------------------


    //Achievement "Anzahl x Kunden": Anfang

    //Achievement "Anzahl x Kunden":  Ende
    //-------------------------------------


    //Achievement "Kaufe x Filialen": Anfang

    //Achievement "Kaufe x Filialen":  Ende
    //-------------------------------------


    //Achievement "Vergebe x Kredite": Anfang

    //Achievement "Vergebe x Kredite":  Ende
    //-------------------------------------


    //Achievement "Entlasse keine Mitarbeiter für x Tage": Anfang

    //Achievement "Entlasse keine Mitarbeiter für x Tage":  Ende
    //-------------------------------------


    //Achievement "Verdiene x mit Aktienhandel": Anfang

    //Achievement "Verdiene x mit Aktienhandel":  Ende
    //-------------------------------------


    //Achievement "Upragade das IT Gebäude 5 mal":  Anfang
    int achievement1;
    public void AchUpdateIT()
    {
        StartCoroutine(ExecuteAchIT());
    }

    IEnumerator ExecuteAchIT()
    {
        yield return StartCoroutine(DatenLesenIT());
        AusgabeIT();
    }

    IEnumerator DatenLesenIT()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);
        WWW www = new WWW("http://localhost/Test/AchievementItLesen.php", form);
        yield return www;
        string achievement1Db = www.text.Split('-')[0];
        achievement1 = Convert.ToInt32(achievement1Db);   
    }
    public void AusgabeIT()
    {
        if (achievement1 == 0)
        {
            Ach2.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement1 == 1)
        {
            Ach2.text = "<sprite=0> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement1 == 2)
        {
            Ach2.text = "<sprite=0> <sprite=0> <sprite=1> <sprite=1> <sprite=1>";
        }
        else if (achievement1 == 3)
        {
            Ach2.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=1> <sprite=1>";
        }
        else if (achievement1 == 4)
        {
            Ach2.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=1>";
        }
        else if (achievement1 == 5)
        {
            Ach2.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=0>";
        }
    }
    //Achievement "Upragade das IT Gebäude 5 mal":  Ende
    //-------------------------------------
   





}




/*void AchUpdate2()
{
    int test = 4;
    if (test == 0)
    {
        Ach2.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
    }
    else if(test == 1)
    {
        Ach2.text = "<sprite=0> <sprite=1> <sprite=1> <sprite=1> <sprite=1>";
    } 
    else if (test == 2)
    {
        Ach2.text = "<sprite=0> <sprite=0> <sprite=1> <sprite=1> <sprite=1>";
    } 
    else if (test == 3)
    {
        Ach2.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=1> <sprite=1>";
    }
    else if (test == 4)
    {
        Ach2.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=1>";
    }
    else if (test == 5)
    {
        Ach2.text = "<sprite=0> <sprite=0> <sprite=0> <sprite=0> <sprite=0>";
    }
}*/

