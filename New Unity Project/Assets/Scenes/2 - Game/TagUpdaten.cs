using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagUpdaten : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TagErhoehen()
    {
        StartCoroutine(TagAendern());
    }
    IEnumerator TagAendern()
    {
        Debug.Log("Tag Ändern wird ausgeführt");
        string username = GlobalVariables.username;
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        WWW www = new WWW("http://dominik.grandpa-kitchen.com/PHP-Skripte/TagUpdaten.php", form);
        yield return www;
        
        Debug.Log("Tag geändert");


    }
}
