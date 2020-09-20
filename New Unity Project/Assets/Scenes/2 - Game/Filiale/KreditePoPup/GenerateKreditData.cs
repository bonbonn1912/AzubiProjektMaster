using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateKreditData : MonoBehaviour
{
    public Color TextColor;
    public Text Scrolltext;
    public void ButtonFetch()
    {
        StartCoroutine(FetchData());


    }

    IEnumerator FetchData()
    {
        WWWForm fetchform = new WWWForm();
        fetchform.AddField("user", GlobalVariables.username);
        WWW fetch = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/FetchData.php", fetchform);
        yield return fetch;
        string[] s = fetch.text.Split('/');
        string line = fetch.text;

        line = line.Replace("@", System.Environment.NewLine);
        Scrolltext.text = line;
        Scrolltext.color = TextColor;





        /* for(int i = 0; i < s.Length - 1; i++)
        {
            Debug.Log(s[i]);
        }

        Scrolltext.text = s[2]; */
    }
}
