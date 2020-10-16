using JetBrains.Annotations;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Submitbutton : MonoBehaviour
{
    public GameObject Submitbuttonwerbung;
    public Text Werbungstextbutton;
    public int DayTemp = 0;
    public int i = 0;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.7f);
        DayTemp = GlobalVariables.day;
        
        while (i < 100000)
        {
            Debug.Log(DayTemp + "<<<<<>>>>>" + GlobalVariables.day);
            yield return new WaitForSeconds(5);
        }
    }

   
    IEnumerator KundenUndBalanceUpdate()
    {

        string username = GlobalVariables.username;
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("Balance", GlobalVariables.balance);
        form.AddField("kunde", GlobalVariables.kundenanzahl);
        // WWW www = new WWW("http://dominik.grandpa-kitchen.com/PHP-Skripte/Kunden&BalanceUpdate.php", form);
        // WWW www = new WWW("https://dominikw.de/AzubiProjekt/Kunden&BalanceUpdate.php", form);
        WWW www = new WWW("https://dominikw.de/AzubiProjekt/KundenBalanceUpdate.php", form);
        yield return www;

    }

    public void WerbungSubmit()
    {
        
        if((DayTemp + 10) <= GlobalVariables.day)
        {

            DayTemp = GlobalVariables.day;
            switch (GlobalVariables.werbungsswitch)
            {


                //abwarten
                case 1:
                    GlobalVariables.kundenanzahl += 1;
                    GlobalVariables.werbungsswitch = 0;
                    Werbungstextbutton.text = "Werbung 1 geschaltet";
                    KundenUndBalanceUpdate();
                    //Debug.Log("case 1");
                    break;

                //buswerbung
                case 2:
                    GlobalVariables.kundenanzahl += 10;
                    GlobalVariables.balance -= 20000;
                    GlobalVariables.werbungsswitch = 0;
                    Werbungstextbutton.text = "Werbung 2 geschaltet";
                    KundenUndBalanceUpdate();
                    //Debug.Log("case 2");
                    break;

                //feier
                case 3:
                    GlobalVariables.kundenanzahl += 30;
                    GlobalVariables.balance -= 50000;
                    GlobalVariables.werbungsswitch = 0;
                    Werbungstextbutton.text = "Werbung 3 geschaltet";
                    KundenUndBalanceUpdate();
                    //Debug.Log("case 3");
                    break;

                //online
                case 4:
                    GlobalVariables.kundenanzahl += 180;
                    GlobalVariables.balance -= 450000;
                    GlobalVariables.werbungsswitch = 0;
                    Werbungstextbutton.text = "Werbung 4 geschaltet";
                    KundenUndBalanceUpdate();
                    //Debug.Log("case 4");
                    break;

                //plakate
                case 5:
                    GlobalVariables.kundenanzahl += 5;
                    GlobalVariables.balance -= 10000;
                    GlobalVariables.werbungsswitch = 0;
                    Werbungstextbutton.text = "Werbung 5 geschaltet";
                    KundenUndBalanceUpdate();
                    //Debug.Log("case 5");
                    break;

                //tvwerbung
                case 6:
                    GlobalVariables.kundenanzahl += 120;
                    GlobalVariables.balance -= 300000;
                    GlobalVariables.werbungsswitch = 0;
                    Werbungstextbutton.text = "Werbung 6 geschaltet";
                    KundenUndBalanceUpdate();
                    //Debug.Log("case 6");
                    break;

                //auto
                case 7:
                    GlobalVariables.kundenanzahl += 15;
                    GlobalVariables.balance -= 15000;
                    GlobalVariables.werbungsswitch = 0;
                    Werbungstextbutton.text = "Werbung 7 geschaltet";
                    KundenUndBalanceUpdate();
                    //Debug.Log("case 7");
                    break;

                //zeitung
                case 8:
                    GlobalVariables.kundenanzahl += 5;
                    GlobalVariables.balance -= 5000;
                    GlobalVariables.werbungsswitch = 0;
                    Werbungstextbutton.text = "Werbung 8 geschaltet";
                    KundenUndBalanceUpdate();
                    //Debug.Log("case 8");
                    break;

                //zusatz
                case 9:
                    GlobalVariables.kundenanzahl += 5;
                    GlobalVariables.balance -= 5000;
                    GlobalVariables.werbungsswitch = 0;
                    Werbungstextbutton.text = "Werbung 9 geschaltet";
                    KundenUndBalanceUpdate();
                    // Debug.Log("case 9");
                    break;
            }
        }
        else
        {
            Werbungstextbutton.text = "Werbung noch am Laufen, bitte versuche es zu einem späteren Zeitpunkt erneut. In der Regel laufen Werbungen x Tage";
            //Debug.Log("Else Statement");
        }
    }
        
}
