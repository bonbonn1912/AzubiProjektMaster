//Autor: Thorge Siemens
//Stand: 07.05.2020


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boni : MonoBehaviour
{
    int kundenAnzahl;
    double Geld;
    int a, b, c, d, e, f, g, h, i, j, k, l, m, n;
    int counter = 0;
    public void KundenAbfrage()
    {
        if (counter == 0)
        {
            StartCoroutine(Execute());  
        }
        counter = 1;
    }

    IEnumerator Execute()
    {

        Debug.Log("Execute Methode bevor Coroutine gestartet wird");
        yield return StartCoroutine(DatenLesen());
        Debug.Log("Nach der Coroutine");
        StartCoroutine(BoolLesen());
        Debug.Log(" Ausgabe a: " + a);
        Debug.Log("Nach BOOL");
        GeldBonus();
        Debug.Log("Nach Geld");

        StartCoroutine(BoolSchreiben());
        Debug.Log("Nach BOOL Schreiben");
        StartCoroutine(DatenSchreiben());
    }
    IEnumerator DatenLesen()
    {
        WWW www = new WWW("http://localhost/Test/kundenlesen.php");
        yield return www;
        string resultGeld = www.text.Split('-')[1];
        string resultKunden = www.text.Split('-')[0];
        kundenAnzahl = Convert.ToInt32(resultKunden);
        Geld = Convert.ToDouble(resultGeld);


    }
    IEnumerator DatenSchreiben()
    {
        Debug.Log("testc");
        string x = Convert.ToString(kundenAnzahl);
        string y = Convert.ToString(Geld);
        WWWForm form = new WWWForm();
        form.AddField("kunden", x);
        form.AddField("Geldwert", y);
        WWW www = new WWW("http://localhost/Test/kundenschreiben.php", form);
        yield return www;

    }

    IEnumerator BoolLesen()
    {
        Debug.Log("Test 12");
        WWW www = new WWW("http://localhost/Test/boollesen.php");
        yield return www;
        string resultA = www.text.Split('-')[0];
        string resultB = www.text.Split('-')[1];
        string resultC = www.text.Split('-')[2];
        string resultD = www.text.Split('-')[3];
        string resultE = www.text.Split('-')[4];
        string resultF = www.text.Split('-')[5];
        string resultG = www.text.Split('-')[6];
        string resultH = www.text.Split('-')[7];
        string resultI = www.text.Split('-')[8];
        string resultJ = www.text.Split('-')[9];
        string resultK = www.text.Split('-')[10];
        string resultL = www.text.Split('-')[11];
        string resultM = www.text.Split('-')[12];
        string resultN = www.text.Split('-')[13];
        a = Convert.ToInt32(resultA);
        b = Convert.ToInt32(resultB);
        c = Convert.ToInt32(resultC);
        d = Convert.ToInt32(resultD);
        e = Convert.ToInt32(resultE);
        f = Convert.ToInt32(resultF);
        g = Convert.ToInt32(resultG);
        h = Convert.ToInt32(resultH);
        i = Convert.ToInt32(resultI);
        j = Convert.ToInt32(resultJ);
        k = Convert.ToInt32(resultK);
        l = Convert.ToInt32(resultL);
        m = Convert.ToInt32(resultM);
        n = Convert.ToInt32(resultN);

    }
    IEnumerator BoolSchreiben()
    {
        string a1 = Convert.ToString(a);
        Debug.Log(a1);
        string b1 = Convert.ToString(b);
        string c1 = Convert.ToString(c);
        string d1 = Convert.ToString(d);
        string e1 = Convert.ToString(e);
        string f1 = Convert.ToString(e);
        string g1 = Convert.ToString(g);
        string h1 = Convert.ToString(h);
        string i1 = Convert.ToString(i);
        string j1 = Convert.ToString(j);
        string k1 = Convert.ToString(k);
        string l1 = Convert.ToString(l);
        string m1 = Convert.ToString(m);
        string n1 = Convert.ToString(n);

        WWWForm form = new WWWForm();
        form.AddField("A", a1);
        form.AddField("B", b1);
        form.AddField("C", c1);
        form.AddField("D", d1);
        form.AddField("E", e1);
        form.AddField("F", f1);
        form.AddField("G", g1);
        form.AddField("H", h1);
        form.AddField("I", i1);
        form.AddField("J", j1);
        form.AddField("K", k1);
        form.AddField("L", l1);
        form.AddField("M", m1);
        form.AddField("N", n1);

        WWW www = new WWW("http://localhost/Test/boolschreiben.php", form);
        yield return www;

    }


    public void GeldBonus()
    {

        if (a == 0)
        {
            if (kundenAnzahl >= 10)
            {
                Geld = Geld + 5000;
                a = 1;
                Debug.Log("Erste Schleife");
                Debug.Log("Ausgabe if-schleife-a:" +a);
            }
        }
        
            if (b == 0)
            {
                if (kundenAnzahl >= 15)
                {
                    Geld = Geld + 15000;
                    b = 1;
                }
            }

            if (c == 0)
            {
                if (kundenAnzahl >= 30)
                {
                    Geld = Geld + 20000;
                    c = 1;
                }
            }

        if (d == 0)
        {
            if (kundenAnzahl >= 50)
            {
                Geld = Geld + 30000;
                d = 1;
            }
        }

        if (e == 0)
        {
            if (kundenAnzahl >= 100)
            {
                Geld = Geld + 50000;
                e = 1;
            }
        }

        if (f == 0)
        {
            if (kundenAnzahl >= 200)
            {
                Geld = Geld + 100000;
                f = 1;
            }

        }
        if (g == 0)
        {
            if (kundenAnzahl >= 1000)
            {
                Geld = Geld + 500000;
                g = 1;
            }
        }

        if (h == 0)
        {
            if (kundenAnzahl >= 5000)
            {
                Geld = Geld + 4000000;
                h = 1;
            }
        }

        if (i == 0)
        {
            if (kundenAnzahl >= 10000)
            {
                Geld = Geld + 8000000;
                i = 1;
            }
        }

        if (j == 0)
        {
            if (kundenAnzahl >= 25000)
            {
                Geld = Geld + 16000000;
                j = 1;
            }
        }

        if (k == 0)
        {
            if (kundenAnzahl >= 50000)
            {
                Geld = Geld + 35000000;
                k = 1;
            }
        }

        if (l == 0)
        {
            if (kundenAnzahl >= 200000)
            {
                Geld = Geld + 150000000;
                l = 1;
            }
        }

        if (m == 0)
        {
            if (kundenAnzahl >= 500000)
            {
                Geld = Geld + 275000000;
                m = 1;
            }
        }
        
        if (n == 0)
        {
            if (kundenAnzahl >= 1000000)
            {
                Geld = Geld + 750000000;
                n = 1;
            }

            }
        }
    }