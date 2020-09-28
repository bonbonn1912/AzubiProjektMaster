using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class AktienKurseLesen : MonoBehaviour
{
    public static List<int> AktienListeAktie1 = new List<int> { };
   // public List<int> valueList = new List<int> { };
    public static string[] stringresultAktie1 = new string[50];
    public static int[] intresultAktie1 = new int[50];

    public static List<int> AktienListeAktie2 = new List<int> { };
    public static string[] stringresultAktie2 = new string[50];
    public static int[] intresultAktie2 = new int[50];

    public static List<int> AktienListeAktie3 = new List<int> { };
    public static string[] stringresultAktie3 = new string[50];
    public static int[] intresultAktie3 = new int[50];

    public static List<int> AktienListeAktie4 = new List<int> { };
    public static string[] stringresultAktie4 = new string[50];
    public static int[] intresultAktie4 = new int[50];

    public static List<int> AktienListeAktie5 = new List<int> { };
    public static string[] stringresultAktie5 = new string[50];
    public static int[] intresultAktie5 = new int[50];


    // public Window_Graph Aktie1;
    public List<GameObject> gameObjectList;


    public void LesenAktie1()
    {
        StartCoroutine(FetchShareData("Aktie1", 50, AktienListeAktie1, stringresultAktie1,intresultAktie1, Window_Graph.valueList1));
        
    }
    public void LesenAktie2()
    {
        StartCoroutine(FetchShareData("Aktie2", 50, AktienListeAktie2, stringresultAktie2, intresultAktie2, Window_Graph.valueList2));
    }

    public void LesenAktie3()
    {
        StartCoroutine(FetchShareData("Aktie3", 50, AktienListeAktie3, stringresultAktie3, intresultAktie3, Window_Graph.valueList3));
    }

    public void LesenAktie4()
    {
        StartCoroutine(FetchShareData("Aktie4", 50, AktienListeAktie4, stringresultAktie4, intresultAktie4, Window_Graph.valueList4));
    }

    IEnumerator FetchShareData(string Aktienname, int lastamount, List<int> AktienListe, string[] Result,int[] intResult, List<int> valueList)
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
        valueList.Clear();
        for(int i=0; i<intResult.Length; i++)
        {
           
            valueList.Add(intResult[i]);
        }

        // Debug.Log(String.Join(",", AktienListe));
      //   Window_Graph.valueList1 = AktienListe;
      
    }
}
