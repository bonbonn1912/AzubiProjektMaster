using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kreditlaufzeit : MonoBehaviour
{
   public void LautZeitVeringern()
    {
        Debug.Log("1. triggered");
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
       
        WWW www = new WWW("http://dominik.grandpa-kitchen.com/PHP-Skripte/KrediteAbfragen.php", form);
        // Debug.Log("Neues Kapital:" + GlobalVariables.balance);
        yield return www;
         string[] IDs = www.text.Split('-');
              for(int i = 0; i<IDs.Length-1; i++)
        {

            WWWForm ausgelaufen = new WWWForm();
            ausgelaufen.AddField("LID", IDs[i]);
            ausgelaufen.AddField("PID", GlobalVariables.PID);
            WWW auslaufen = new WWW("http://dominik.grandpa-kitchen.com/PHP-Skripte/KreditHistory.php", ausgelaufen);
            yield return auslaufen;
            Debug.Log(auslaufen.text);

           
            WWWForm form1 = new WWWForm();
            form1.AddField("LID", IDs[i]);
            WWW www1 = new WWW("http://dominik.grandpa-kitchen.com/PHP-Skripte/KreditWert.php", form1);
            yield return www1;

            int creditvalue = Convert.ToInt32(www1.text);
            WWWForm formdelete = new WWWForm();
            formdelete.AddField("LID", IDs[i]);
            WWW wwwdelete = new WWW("http://dominik.grandpa-kitchen.com/PHP-Skripte/DeleteKredit.php", formdelete);
            yield return wwwdelete;
            
            WWWForm updateKapital = new WWWForm();
            updateKapital.AddField("Username", GlobalVariables.username);
            GlobalVariables.balance = GlobalVariables.balance + creditvalue;
           
            updateKapital.AddField("Balance", GlobalVariables.balance);
            WWW payout = new WWW("http://dominik.grandpa-kitchen.com/PHP-Skripte/UpdateKreditBalance.php", updateKapital);
            yield return payout;
            Debug.Log(payout.text);
        }
             
    }

    IEnumerator UpdateRuntime()
    {
        WWWForm form = new WWWForm();
        form.AddField("User", GlobalVariables.username);
        WWW www = new WWW("http://dominik.grandpa-kitchen.com/PHP-Skripte/UpdateRuntime.php", form);
        yield return www;
    }

    
    


}
