using UnityEngine;
using UnityEngine.UI;

public class Submitbutton : MonoBehaviour
{
    public GameObject Submitbuttonwerbung;
    public Text Werbungstextbutton;
    public void WerbungSubmit()
    {
        switch (GlobalVariables.werbungsswitch)
        {
            //abwarten
            case 1:
                //GlobalVariables.kundenanzahl += 10;
                //GlobalVariables.werbungsswitch = 0;
                Werbungstextbutton.text = "Werbung geschaltet";
                Debug.Log("case 1");
                break;

            //buswerbung
            case 2:
                //GlobalVariables.kundenanzahl += 10;
                //GlobalVariables.balance -= 20000;
                //GlobalVariables.werbungsswitch = 0;
                Werbungstextbutton.text = "Werbung geschaltet";
                Debug.Log ("case 2");
                break;
            
            //feier
            case 3:
                //GlobalVariables.kundenanzahl += 30;
                //GlobalVariables.balance -= 2000;
                //GlobalVariables.werbungsswitch = 0;
                Werbungstextbutton.text = "Werbung geschaltet";
                Debug.Log("case 3");
                break;

            //online
            case 4:
                //GlobalVariables.kundenanzahl += 180;
                //GlobalVariables.balance -= 45000;
                //GlobalVariables.werbungsswitch = 0;
                Werbungstextbutton.text = "Werbung geschaltet";
                Debug.Log("case 4");
                break;
            
            //plakate
            case 5:
                //GlobalVariables.balance -= 500;
                //GlobalVariables.werbungsswitch = 0;
                Werbungstextbutton.text = "Werbung geschaltet";
                Debug.Log("case 5");
                
                break;

            //tvwerbung
            case 6:
                //GlobalVariables.kundenanzahl += 120;
                //GlobalVariables.balance -= 30000;
                //GlobalVariables.werbungsswitch = 0;
                Werbungstextbutton.text = "Werbung geschaltet";
                Debug.Log("case 6");
                break;

            //auto
            case 7:
                //GlobalVariables.kundenanzahl += 5;
                //GlobalVariables.balance -= 500;
                //GlobalVariables.werbungsswitch = 0;
                Werbungstextbutton.text = "Werbung geschaltet";
                Debug.Log("case 7");
                break;

            //zeitung
            case 8:
                //GlobalVariables.kundenanzahl += 5;
                //GlobalVariables.balance -= 500;
                //GlobalVariables.werbungsswitch = 0;
                Werbungstextbutton.text = "Werbung geschaltet";
                Debug.Log("case 8");
                break;

            //zusatz
            case 9:
                //GlobalVariables.kundenanzahl += 5;
                //GlobalVariables.balance -= 500;
                //GlobalVariables.werbungsswitch = 0;
                Werbungstextbutton.text = "Werbung geschaltet";
                Debug.Log("case 9");
                break;
        }
    }
}
