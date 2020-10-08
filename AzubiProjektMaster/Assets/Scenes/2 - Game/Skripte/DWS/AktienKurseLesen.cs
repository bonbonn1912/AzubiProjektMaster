using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class AktienKurseLesen : MonoBehaviour
{
    public static List<int> AktienListeAktie1 = new List<int> { };
    // public List<int> valueList = new List<int> { };
    public static string[] stringresultAktie1; // = new string[GlobalVariables.AktienIndex];
    public static int[] intresultAktie1; // = new int[GlobalVariables.AktienIndex];


    public static List<int> AktienListeAktie2 = new List<int> { };
    public static string[] stringresultAktie2; // = new string[GlobalVariables.AktienIndex];
    public static int[] intresultAktie2; // = new int[GlobalVariables.AktienIndex];

    public static List<int> AktienListeAktie3 = new List<int> { };
    public static string[] stringresultAktie3;//  = new string[GlobalVariables.AktienIndex];
    public static int[] intresultAktie3; // = new int[GlobalVariables.AktienIndex];

    public static List<int> AktienListeAktie4 = new List<int> { };
    public static string[] stringresultAktie4; // = new string[GlobalVariables.AktienIndex];
    public static int[] intresultAktie4; // = new int[GlobalVariables.AktienIndex];

    public static List<int> AktienListeAktie5 = new List<int> { };
    public static string[] stringresultAktie5; // = new string[GlobalVariables.AktienIndex];
    public static int[] intresultAktie5; // = new int[GlobalVariables.AktienIndex];


    public static List<int> valueList1 = new List<int>() { 10, 100 };
    public static List<int> valueList2 = new List<int>() { 10, 100 };
     public static List<int> valueList3 = new List<int>() { 10, 100 };
     public static List<int> valueList4 = new List<int>() { 10, 100 };
     public static List<int> valueList5 = new List<int>() { 10, 100 };
  // public static List<int> valueList6 = new List<int>() { 10, 100 };

    // public Window_Graph Aktie1;
    public List<GameObject> gameObjectList;


    public void LesenAktie1()
    {
       
        StartCoroutine(FetchShareData("Aktie1", GlobalVariables.AktienIndex, AktienListeAktie1, stringresultAktie1,intresultAktie1, valueList1));
        
    }
    public void LesenAktie2()
    {
        StartCoroutine(FetchShareData("Aktie2", GlobalVariables.AktienIndex, AktienListeAktie2, stringresultAktie2, intresultAktie2, valueList2));
    }

    public void LesenAktie3()
    {
        StartCoroutine(FetchShareData("Aktie3", GlobalVariables.AktienIndex, AktienListeAktie3, stringresultAktie3, intresultAktie3, valueList3));
    }

    public void LesenAktie4()
    {
        StartCoroutine(FetchShareData("Aktie4", GlobalVariables.AktienIndex, AktienListeAktie4, stringresultAktie4, intresultAktie4, valueList4));
    }

    public void LesenAktie5()
    {
        StartCoroutine(FetchShareData("Aktie5", GlobalVariables.AktienIndex, AktienListeAktie5, stringresultAktie5, intresultAktie5, valueList5));
    }

    IEnumerator FetchShareData(string Aktienname, int lastamount, List<int> AktienListe, string[] Result,int[] intResult, List<int> valueList)
    {
        WWWForm FetchShareData = new WWWForm();
        FetchShareData.AddField("username", GlobalVariables.username);
        FetchShareData.AddField("sharename", Aktienname);
        FetchShareData.AddField("amount", lastamount);

        WWW fetch = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/AktienKurseLesen.php", FetchShareData);
        yield return fetch;
        
        string[] temp = fetch.text.Split('/');
        Result = new string[temp.Length-1];
        intResult = new int[Result.Length];
        for(int i =0; i < temp.Length - 1; i++)
        {
            Result[i] = temp[i];
        }

        for(int i = 0; i < temp.Length - 1; i++)
        {
            intResult[i] = Convert.ToInt32(Result[i]);
        }
        valueList.Clear();
        for(int i=0; i<intResult.Length; i++)
        {
           
            valueList.Add(intResult[i]);
        }
       // Debug.Log(String.Join(",", valueList));
        valueList.Reverse();
        
     //   Debug.Log("Liste generiert");
      //   Window_Graph.valueList1 = AktienListe;
      
    }
}
