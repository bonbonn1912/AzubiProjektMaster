using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;

public class KundenErhoehen : MonoBehaviour
{
    // Start is called before the first frame update
   public void KundenDB()
    {
        StartCoroutine(PushDB());
    }

    IEnumerator PushDB()
    {
        WWWForm pushdb = new WWWForm();
        int kundenzhal = 25;
        pushdb.AddField("username", GlobalVariables.username);
        // pushdb.AddField("kunde", Convert.ToString(kundenzhal));
       // pushdb.AddField("Balance", GlobalVariables.balance);

        WWW www = new WWW("https://dominikw.de/AzubiProjekt/IncreaseKunde.php", pushdb);
        yield return www;
        Debug.Log("kunden erhohene" + www.text);
    }
}
