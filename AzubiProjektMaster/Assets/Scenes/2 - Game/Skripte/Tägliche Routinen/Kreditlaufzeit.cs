using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kreditlaufzeit : MonoBehaviour
{
    public void LautZeitVeringern()
    {
        StartCoroutine(execute());
    }

    IEnumerator execute()
    {
        yield return StartCoroutine(KrediteAbfrage());
        yield return StartCoroutine(UpdateRuntime());
    }

    IEnumerator KrediteAbfrage()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", GlobalVariables.username);
        WWW www = new WWW("https://dominikw.de/AzubiProjekt/KrediteAbfragenDEV.php", form);
        yield return www;
        string[] IDs = www.text.Split('-');
        for (int i = 0; i < IDs.Length - 1; i++)
        {
            WWWForm ausgelaufen = new WWWForm();
            ausgelaufen.AddField("LID", IDs[i]);
            ausgelaufen.AddField("PID", GlobalVariables.PID);
            WWW auslaufen = new WWW("http://dominik.grandpa-kitchen.com/PHP-Skripte/KreditHistory.php", ausgelaufen);
            yield return auslaufen;

            WWWForm form1 = new WWWForm();
            form1.AddField("LID", IDs[i]);

            WWW www1 = new WWW("https://dominikw.de/AzubiProjekt/KreditWertDEV.php", form1);
            yield return www1;
            int creditvalue = Convert.ToInt32(www1.text);
            WWWForm formdelete = new WWWForm();
            formdelete.AddField("LID", IDs[i]);
            WWW wwwdelete = new WWW("https://dominikw.de/AzubiProjekt/DeleteKreditDEV.php", formdelete);
            yield return wwwdelete;

            WWWForm updateKapital = new WWWForm();
            updateKapital.AddField("Username", GlobalVariables.username);
            GlobalVariables.balance = GlobalVariables.balance + creditvalue;

            updateKapital.AddField("Balance", GlobalVariables.balance);
            WWW payout = new WWW("https://dominikw.de/AzubiProjekt/UpdateBalanceDEV.php", updateKapital);

            yield return payout;
        }
    }

    IEnumerator UpdateRuntime()
    {
        WWWForm form = new WWWForm();
        form.AddField("User", GlobalVariables.username);
        WWW www = new WWW("https://dominikw.de/AzubiProjekt/UpdateRuntimeDEV.php", form);
        yield return www;
    }
}
