using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Datenbank: 0 = 0 Achievements der Kategorie, 1 = 1 Achievement der Kategorie usw.
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
        Ach7.text = "<sprite=1>";
        Ach8.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        //InvokeRepeating("AchUpdate1", 5.0f, 5.0f); //Dadurch wird Methode AchUpdate1 alle 5 Sekunden ausgeführt
        InvokeRepeating("AchUpdate2", 5.0f, 5.0f);
        //InvokeRepeating("AchUpdate3", 5.0f, 5.0f);
        //InvokeRepeating("AchUpdate4", 5.0f, 5.0f);
        //InvokeRepeating("AchUpdate5", 5.0f, 5.0f);
        //InvokeRepeating("AchUpdate6", 5.0f, 5.0f);
        //InvokeRepeating("AchUpdate7", 5.0f, 5.0f);
        //InvokeRepeating("AchUpdate8", 5.0f, 5.0f);
    }

    /*void AchUpdate1()
    {

        //TBD: Datenbankabfrage der Achievements
        if( WERT DATENBANK = 0)
        {
            Ach1.text = "<sprite=1>";
        }
        else
        {
            Ach1.text = "<sprite=0>";
        }
    }*/

    void AchUpdate2()
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
    }

    void AchUpdate3()
    {

    }

    void AchUpdate4()
    {

    }

    void AchUpdate5()
    {

    }

    void AchUpdate6()
    {

    }

    void AchUpdate7()
    {

    }

    void AchUpdate8()
    {

    }

}