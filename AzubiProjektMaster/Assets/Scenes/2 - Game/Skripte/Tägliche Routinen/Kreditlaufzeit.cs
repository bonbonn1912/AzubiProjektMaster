using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kreditlaufzeit : MonoBehaviour
{
   public void LautZeitVeringern()
    {
       // Debug.Log("1. triggered");
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

        WWW www = new WWW("http://dominik.grandpa-kitchen.com/PHP-Skripte/KrediteAbfragenDEV.php", form);
       // WWW www = new WWW("https://dominikw.de/AzubiProjekt/KrediteAbfragen.php", form);
      //  WWW www = new WWW("https://dominikw.de/AzubiProjekt/KrediteAbfragenDEV.php", form);
        // Debug.Log("Neues Kapital:" + GlobalVariables.balance);
        yield return www;
        //Debug.Log(www.text);
         string[] IDs = www.text.Split('-');
        
        for (int i = 0; i<IDs.Length-1; i++)
        {

            WWWForm ausgelaufen = new WWWForm();
            ausgelaufen.AddField("LID", IDs[i]);
            ausgelaufen.AddField("PID", GlobalVariables.PID);
            WWW auslaufen = new WWW("http://dominik.grandpa-kitchen.com/PHP-Skripte/KreditHistory.php", ausgelaufen);
            yield return auslaufen;
            

           
            WWWForm form1 = new WWWForm();
            form1.AddField("LID", IDs[i]);
            //Debug.Log("LID: "+IDs[i]);
             WWW www1 = new WWW("http://dominik.grandpa-kitchen.com/PHP-Skripte/KreditWertDEV.php", form1);
          // WWW www1 = new WWW("https://dominikw.de/AzubiProjekt/KreditWert.php", form1);
          //  WWW www1 = new WWW("https://dominikw.de/AzubiProjekt/KreditWertDEV.php", form1);
            yield return www1;
            //Debug.Log("Kreditwert" + www1.text);
            int creditvalue = Convert.ToInt32(www1.text);
            WWWForm formdelete = new WWWForm();
            formdelete.AddField("LID", IDs[i]);
            WWW wwwdelete = new WWW("http://dominik.grandpa-kitchen.com/PHP-Skripte/DeleteKreditDEV.php", formdelete);
          //  WWW wwwdelete = new WWW("https://dominikw.de/AzubiProjekt/DeleteKredit.php", formdelete);
           // WWW wwwdelete = new WWW("https://dominikw.de/AzubiProjekt/DeleteKreditDEV.php", formdelete);
            yield return wwwdelete;
           
            WWWForm updateKapital = new WWWForm();
            updateKapital.AddField("Username", GlobalVariables.username);
            GlobalVariables.balance = GlobalVariables.balance + creditvalue;
           
            updateKapital.AddField("Balance", GlobalVariables.balance);
              WWW payout = new WWW("http://dominik.grandpa-kitchen.com/PHP-Skripte/UpdateKreditBalanceDEV.php", updateKapital);
            // WWW payout = new WWW("https://dominikw.de/AzubiProjekt/UpdateBalance.php", updateKapital);
           // WWW payout = new WWW("https://dominikw.de/AzubiProjekt/UpdateBalanceDEV.php", updateKapital);

            yield return payout;
            
        }
             
    }

    IEnumerator UpdateRuntime()
    {
        //Debug.Log("tag -1");
        WWWForm form = new WWWForm();
        form.AddField("User", GlobalVariables.username);
        WWW www = new WWW("http://dominik.grandpa-kitchen.com/PHP-Skripte/UpdateRuntimeDEV.php", form);
        // WWW www = new WWW("https://dominikw.de/AzubiProjekt/UpdateRuntime.php", form);
        // WWW www = new WWW("https://dominikw.de/AzubiProjekt/UpdateRuntimeDEV.php", form);
        yield return www;
    }

    
    


}
