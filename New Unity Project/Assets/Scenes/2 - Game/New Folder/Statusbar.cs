using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statusbar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("test");
        int x = 0;
        if(x == 40)
        {
            StartCoroutine(StatusBarUpdate());
            x = 0;
        }
        x++;
        
    }

    IEnumerator StatusBarUpdate()
    {
        WWW www = new WWW("https://http://dominik.grandpa-kitchen.com/PHP-Skripte/statusbarupdate.php");
        yield return www;
        string[] results = www.text.Split('|');
        Debug.Log(results[0]);
        Debug.Log(results[2]);
        Debug.Log(results[4]);

      
    }
}
