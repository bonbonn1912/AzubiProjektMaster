using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Random = UnityEngine.Random;


public class AktienKurseGenerieren : MonoBehaviour
{

    public Text Aktie1Kurs;
    public Text Aktie2Kurs;
    public Text Aktie3Kurs;
    public Text Aktie4Kurs;
    public Text Aktie5Kurs;


    public Text DifferenzAktie1;
    public Text Aktie1Prozent1;
    public Text Aktie1Vorzeichen;

    public Text DifferenzAktie2;
    public Text Aktie2Prozent1;
    public Text Aktie2Vorzeichen;

    public Text DifferenzAktie3;
    public Text Aktie3Prozent1;
    public Text Aktie3Vorzeichen;

    public Text DifferenzAktie4;
    public Text Aktie4Prozent1;
    public Text Aktie4Vorzeichen;

    public Text DifferenzAktie5;
    public Text Aktie5Prozent1;
    public Text Aktie5Vorzeichen;



    public Color PossDif;
    public Color NegDiv;

    int baseValueAktie1 = 100;
    int MasterValueAktie1 = 100;

    int baseValueAktie2 = 120;
    int MasterValueAktie2 = 120;

    int baseValueAktie3 = 150;
    int MasterValueAktie3 = 150;

    int baseValueAktie4 = 120;
    int MasterValueAktie4 = 120;

    int baseValueAktie5 = 200;
    int MasterValueAktie5 = 200;


    public void KursAktie1()
    {
       // Debug.Log("AktienHandelgetriggert");
        int minValue = MasterValueAktie1 / 2;
        int maxValue = MasterValueAktie1 * 2;


        float kurs = Random.Range(baseValueAktie1 * 0.95f, baseValueAktie1 * 1.05f);

        int a = Mathf.RoundToInt(kurs);
        if (maxValue - a <= maxValue - maxValue * 0.9f)
        {
            float newa = a * 0.75f;
            a = Mathf.RoundToInt(newa);
        }
        Debug.Log("Vorheriger Aktienkurs: " + baseValueAktie1);
         Debug.Log("AktuellerAktienkurs: " + a);
        if(a > baseValueAktie1)
        {
            double c = a;
            double d = baseValueAktie1;

            double quo = (a / d)-1;
            quo = quo * 100;
            
           
            DifferenzAktie1.text = (String.Format("{0:0.00}", quo));
            DifferenzAktie1.color = PossDif;

            Aktie1Vorzeichen.text = "+";
            Aktie1Vorzeichen.color = PossDif;
         
            Aktie1Prozent1.color = PossDif;
           
        }
        else
        {
            double c = a;
            double d = baseValueAktie1;

            double quo = (a / d) - 1;
            quo = (quo * 100)*-1;
            decimal differenz = Math.Abs(a - baseValueAktie1);
            // Debug.Log("Negative differenz der Kurse: "+differenz);
            DifferenzAktie1.text = (String.Format("{0:0.00}", quo));
            DifferenzAktie1.color = NegDiv;
            Aktie1Vorzeichen.text = "-";
            Aktie1Vorzeichen.color = NegDiv;
            Aktie1Prozent1.color = NegDiv;

        }

        baseValueAktie1 = a;

        Aktie1Kurs.text = Convert.ToString(a);
      

    }

    public void KursAktie2()
    {
      //  Debug.Log("AktienHandelgetriggert");
        int minValue = MasterValueAktie2 / 2;
        int maxValue = MasterValueAktie2 * 2;


        float kurs = Random.Range(baseValueAktie2 * 0.95f, baseValueAktie2 * 1.05f);

        int a = Mathf.RoundToInt(kurs);
        if (maxValue - a <= maxValue - maxValue * 0.9f)
        {
            float newa = a * 0.75f;
            a = Mathf.RoundToInt(newa);
        }
        if (a > baseValueAktie2)
        {
            double c = a;
            double d = baseValueAktie2;

            double quo = (a / d) - 1;
            quo = quo * 100;


            DifferenzAktie2.text = (String.Format("{0:0.00}", quo));
            DifferenzAktie2.color = PossDif;

            Aktie2Vorzeichen.text = "+";
            Aktie2Vorzeichen.color = PossDif;

            Aktie2Prozent1.color = PossDif;

        }
        else
        {
            double c = a;
            double d = baseValueAktie2;

            double quo = (a / d) - 1;
            quo = (quo * 100) * -1;
            
            DifferenzAktie2.text = (String.Format("{0:0.00}", quo));
            DifferenzAktie2.color = NegDiv;
            Aktie2Vorzeichen.text = "-";
            Aktie2Vorzeichen.color = NegDiv;
            Aktie2Prozent1.color = NegDiv;

        }
        baseValueAktie2 = a;

        Aktie2Kurs.text = Convert.ToString(a);


    }

    public void KursAktie3()
    {
      //  Debug.Log("AktienHandelgetriggert");
        int minValue = MasterValueAktie3 / 2;
        int maxValue = MasterValueAktie3 * 2;


        float kurs = Random.Range(baseValueAktie3 * 0.95f, baseValueAktie3 * 1.05f);

        int a = Mathf.RoundToInt(kurs);
        if (maxValue - a <= maxValue - maxValue * 0.9f)
        {
            float newa = a * 0.75f;
            a = Mathf.RoundToInt(newa);
        }
        if (a > baseValueAktie3)
        {
            double c = a;
            double d = baseValueAktie3;

            double quo = (a / d) - 1;
            quo = quo * 100;


            DifferenzAktie3.text = (String.Format("{0:0.00}", quo));
            DifferenzAktie3.color = PossDif;

            Aktie3Vorzeichen.text = "+";
            Aktie3Vorzeichen.color = PossDif;

            Aktie3Prozent1.color = PossDif;

        }
        else
        {
            double c = a;
            double d = baseValueAktie3;

            double quo = (a / d) - 1;
            quo = (quo * 100) * -1;
            
            DifferenzAktie3.text = (String.Format("{0:0.00}", quo));
            DifferenzAktie3.color = NegDiv;
            Aktie3Vorzeichen.text = "-";
            Aktie3Vorzeichen.color = NegDiv;
            Aktie3Prozent1.color = NegDiv;

        }
        baseValueAktie3 = a;

        Aktie3Kurs.text = Convert.ToString(a);


    }

    public void KursAktie4()
    {
      //  Debug.Log("AktienHandelgetriggert");
        int minValue = MasterValueAktie4 / 2;
        int maxValue = MasterValueAktie4 * 2;


        float kurs = Random.Range(baseValueAktie4 * 0.95f, baseValueAktie4 * 1.05f);

        int a = Mathf.RoundToInt(kurs);
        if (maxValue - a <= maxValue - maxValue * 0.9f)
        {
            float newa = a * 0.75f;
            a = Mathf.RoundToInt(newa);
        }
        if (a > baseValueAktie4)
        {
            double c = a;
            double d = baseValueAktie4;

            double quo = (a / d) - 1;
            quo = quo * 100;


            DifferenzAktie4.text = (String.Format("{0:0.00}", quo));
            DifferenzAktie4.color = PossDif;

            Aktie4Vorzeichen.text = "+";
            Aktie4Vorzeichen.color = PossDif;

            Aktie4Prozent1.color = PossDif;

        }
        else
        {
            double c = a;
            double d = baseValueAktie4;

            double quo = (a / d) - 1;
            quo = (quo * 100) * -1;
            decimal differenz = Math.Abs(a - baseValueAktie4);
            // Debug.Log("Negative differenz der Kurse: "+differenz);
            DifferenzAktie4.text = (String.Format("{0:0.00}", quo));
            DifferenzAktie4.color = NegDiv;
            Aktie4Vorzeichen.text = "-";
            Aktie4Vorzeichen.color = NegDiv;
            Aktie4Prozent1.color = NegDiv;

        }
        baseValueAktie4 = a;

        Aktie4Kurs.text = Convert.ToString(a);


    }

    public void KursAktie5()
    {
       // Debug.Log("AktienHandelgetriggert");
        int minValue = MasterValueAktie5 / 2;
        int maxValue = MasterValueAktie5 * 2;


        float kurs = Random.Range(baseValueAktie5 * 0.95f, baseValueAktie5 * 1.05f);

        int a = Mathf.RoundToInt(kurs);
        if (maxValue - a <= maxValue - maxValue * 0.9f)
        {
            float newa = a * 0.75f;
            a = Mathf.RoundToInt(newa);
        }
        if (a > baseValueAktie5)
        {
            double c = a;
            double d = baseValueAktie5;

            double quo = (a / d) - 1;
            quo = quo * 100;


            DifferenzAktie5.text = (String.Format("{0:0.00}", quo));
            DifferenzAktie5.color = PossDif;

            Aktie5Vorzeichen.text = "+";
            Aktie5Vorzeichen.color = PossDif;

            Aktie5Prozent1.color = PossDif;

        }
        else
        {
            double c = a;
            double d = baseValueAktie5;

            double quo = (a / d) - 1;
            quo = (quo * 100) * -1;
            
            DifferenzAktie5.text = (String.Format("{0:0.00}", quo));
            DifferenzAktie5.color = NegDiv;
            Aktie5Vorzeichen.text = "-";
            Aktie5Vorzeichen.color = NegDiv;
            Aktie5Prozent1.color = NegDiv;

        }
        baseValueAktie5 = a;

        Aktie5Kurs.text = Convert.ToString(a);


    }

    public void KursAktie6()
    {
      //  Debug.Log("AktienHandelgetriggert");
        int minValue = MasterValueAktie1 / 2;
        int maxValue = MasterValueAktie1 * 2;


        float kurs = Random.Range(baseValueAktie1 * 0.95f, baseValueAktie1 * 1.05f);

        int a = Mathf.RoundToInt(kurs);
        if (maxValue - a <= maxValue - maxValue * 0.9f)
        {
            float newa = a * 0.75f;
            a = Mathf.RoundToInt(newa);
        }
        baseValueAktie1 = a;

        Aktie1Kurs.text = Convert.ToString(a);


    }
}
