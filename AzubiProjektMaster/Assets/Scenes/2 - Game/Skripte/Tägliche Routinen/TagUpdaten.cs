using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagUpdaten : MonoBehaviour
{
    public void TagErhoehen()
    {
        StartCoroutine(TagAendern());
    }
    IEnumerator TagAendern()
    {
        string username = GlobalVariables.username;
        WWWForm form = new WWWForm();
        form.AddField("username", username);
         WWW www = new WWW("http://dominik.grandpa-kitchen.com/PHP-Skripte/TagUpdatenDEV.php", form);
        yield return www;
    }
}
