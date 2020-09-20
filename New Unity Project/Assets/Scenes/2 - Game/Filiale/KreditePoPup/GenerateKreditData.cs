using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateKreditData : MonoBehaviour
{
    public Color TextColor;
    public Text Scrolltext;
    public Button Aufsteigend;
    public Button Absteigend;

    string aufsteigen = "";
    string absteigend = "";
    public void ButtonFetch()
    {
        StartCoroutine(FetchData());
        Aufsteigend.interactable = true;
        Absteigend.interactable = true;

    }



    IEnumerator FetchData()
    {
        WWWForm fetchform = new WWWForm();
        fetchform.AddField("user", GlobalVariables.username);
        WWW fetch = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/FetchData.php", fetchform);
        yield return fetch;
        string[] s = fetch.text.Split('/');
        string line = fetch.text;

        line = line.Replace("@", "" + System.Environment.NewLine);
        Scrolltext.text = line;
        Scrolltext.color = TextColor;

        yield return StartCoroutine(FetchDataAbsteigend());
        yield return StartCoroutine(FetchDataAufsteigend());



        /* for(int i = 0; i < s.Length - 1; i++)
        {
            Debug.Log(s[i]);
        }

        Scrolltext.text = s[2]; */
    }

    IEnumerator FetchDataAbsteigend()
    {
        WWWForm fetchform = new WWWForm();
        fetchform.AddField("user", GlobalVariables.username);
        WWW fetch = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/FetchDataAb.php", fetchform);
        yield return fetch;
        string line = fetch.text;
        line = line.Replace("@", "" + System.Environment.NewLine);
        absteigend = line;
        Debug.Log(fetch.text);

    }

    IEnumerator FetchDataAufsteigend()
    {
        WWWForm fetchform = new WWWForm();
        fetchform.AddField("user", GlobalVariables.username);
        WWW fetch = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/FetchDataAuf.php", fetchform);
        yield return fetch;
        string line = fetch.text;
        line = line.Replace("@", "" + System.Environment.NewLine);
        aufsteigen = line;
        
       
    }


    public void AufSteigend()
    {
        Scrolltext.text = aufsteigen;
        Scrolltext.color = TextColor;
    }
    
    public void AbSteigend()
    {
        Scrolltext.text = absteigend;
        Scrolltext.color = TextColor;
    }
}
