using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class AktienKurseLesen : MonoBehaviour
{
    public static List<int> AktienListeAktie1 = new List<int> { };
    public List<int> valueList = new List<int> { };
    public static string[] stringresultAktie1 = new string[50];
    public static int[] intresultAktie1 = new int[50];
    public Window_Graph Aktie1;



    public void LesenAktie1()
    {
        StartCoroutine(FetchShareData("Aktie1", 50, AktienListeAktie1, stringresultAktie1,intresultAktie1, Aktie1));
        
    }

    IEnumerator FetchShareData(string Aktienname, int lastamount, List<int> AktienListe, string[] Result,int[] intResult, Window_Graph AktienNumber)
    {
        WWWForm FetchShareData = new WWWForm();
        FetchShareData.AddField("sharename", Aktienname);
        FetchShareData.AddField("amount", lastamount);

        WWW fetch = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/AktienKurseLesen.php", FetchShareData);
        yield return fetch;
        Result = fetch.text.Split('/');
        for(int i = 0; i < Result.Length - 1; i++)
        {
            intResult[i] = Convert.ToInt32(Result[i]);
        }
        AktienListe.Clear();
        for(int i=0; i<intResult.Length; i++)
        {
           
            AktienListe.Add(intResult[i]);
        }

        // Debug.Log(String.Join(",", AktienListe));
       // valueList = AktienListe;
       //  AktienNumber.ShowGraph(valueList, -1, (int _i) => "" + (_i + 1), (float _f) => "€" + Mathf.RoundToInt(_f));
    }
}
