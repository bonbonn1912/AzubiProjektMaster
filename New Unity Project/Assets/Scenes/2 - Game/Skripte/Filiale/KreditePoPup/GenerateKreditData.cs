using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateKreditData : MonoBehaviour
{
    public Color TextColor;
    public Text Scrolltext;
    public Button Time;
    public Button Value;
    public Button Name;

    string DurationAufsteigen = "";
    string DurationAbsteigen = "";

    string VolumeAufsteigen = "";
    string VolumeAbsteigen = "";

    string NameAufsteigen = "";
    string NameAbsteigen = "";

    bool StateButtonNumber = true;
    bool StateButtonValue = true;
    bool StateButtonName = true;



    public void ButtonFetch()
    {
        
        StartCoroutine(FetchData());
        Time.interactable = true;
        Value.interactable = true;
        Name.interactable = true;
       

    }



    IEnumerator FetchData()
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();
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
        yield return StartCoroutine(FetchDataValueAufsteigend());
        yield return StartCoroutine(FetchDataValueAbsteigend());
        yield return StartCoroutine(FetchDataDurationAufsteigend());
        yield return StartCoroutine(FetchDataDurationAbsteigend());
        watch.Stop();
        float ms = watch.ElapsedMilliseconds;
        Debug.Log("Ladezeit aller Kredit: " + ms + " ms");


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
        fetchform.AddField("Runtime", "Runtime");
        fetchform.AddField("Order", "DESC");
        WWW fetch = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/FetchDataAb.php", fetchform);
        yield return fetch;
        string line = fetch.text;
        line = line.Replace("@", "" + System.Environment.NewLine);
        DurationAbsteigen = line;
        Debug.Log(fetch.text);

    }

    IEnumerator FetchDataAufsteigend()
    {
        WWWForm fetchform = new WWWForm();
        fetchform.AddField("user", GlobalVariables.username);
        fetchform.AddField("Runtime", "Runtime");
        fetchform.AddField("Order", "ASC");
        WWW fetch = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/FetchDataAb.php", fetchform);
        yield return fetch;
        string line = fetch.text;
        line = line.Replace("@", "" + System.Environment.NewLine);
        DurationAufsteigen = line;
        
       
    }

    IEnumerator FetchDataValueAufsteigend()
    {
        WWWForm fetchform = new WWWForm();
        fetchform.AddField("user", GlobalVariables.username);
        fetchform.AddField("Runtime", "Volume");
        fetchform.AddField("Order", "ASC");
        WWW fetch = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/FetchDataAb.php", fetchform);
        yield return fetch;
        string line = fetch.text;
        line = line.Replace("@", "" + System.Environment.NewLine);
        VolumeAufsteigen = line;
    }
    IEnumerator FetchDataValueAbsteigend()
    {
        WWWForm fetchform = new WWWForm();
        fetchform.AddField("user", GlobalVariables.username);
        fetchform.AddField("Runtime", "Volume");
        fetchform.AddField("Order", "DESC");
        WWW fetch = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/FetchDataAb.php", fetchform);
        yield return fetch;
        string line = fetch.text;
        line = line.Replace("@", "" + System.Environment.NewLine);
        VolumeAbsteigen = line;
    }

    IEnumerator FetchDataDurationAufsteigend()
    {
        WWWForm fetchform = new WWWForm();
        fetchform.AddField("user", GlobalVariables.username);
        fetchform.AddField("Runtime", "Name");
        fetchform.AddField("Order", "ASC");
        WWW fetch = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/FetchDataAb.php", fetchform);
        yield return fetch;
        string line = fetch.text;
        line = line.Replace("@", "" + System.Environment.NewLine);
        NameAufsteigen = line;
    }

    IEnumerator FetchDataDurationAbsteigend()
    {
        WWWForm fetchform = new WWWForm();
        fetchform.AddField("user", GlobalVariables.username);
        fetchform.AddField("Runtime", "Name");
        fetchform.AddField("Order", "DESC");
        WWW fetch = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/FetchDataAb.php", fetchform);
        yield return fetch;
        string line = fetch.text;
        line = line.Replace("@", "" + System.Environment.NewLine);
        NameAbsteigen = line;
    }


    public void NumberSort()
    {
        if(StateButtonNumber == true)
        {
            Scrolltext.text = DurationAufsteigen;
            Scrolltext.color = TextColor;
            StateButtonNumber = false;

        }
        else
        {
            Scrolltext.text = DurationAbsteigen;
            Scrolltext.color = TextColor;
            StateButtonNumber = true;
        }
    }
    
    public void ValueSort()
    {
        if(StateButtonValue == true)
        {
            Scrolltext.text = VolumeAufsteigen;
            Scrolltext.color = TextColor;
            StateButtonValue = false;
        }
        else
        {
            Scrolltext.text = VolumeAbsteigen;
            Scrolltext.color = TextColor;
            StateButtonValue = true;
        }
    }

    public void NameSort()
    {
        if(StateButtonName == true)
        {
            Scrolltext.text = NameAufsteigen;
            Scrolltext.color = TextColor;
            StateButtonName = false;
        }
        else
        {
            Scrolltext.text = NameAbsteigen;
            Scrolltext.color = TextColor;
            StateButtonName = true;
        }
    }

}
