using UnityEngine;
using UnityEngine.UI;

public class Werbungen : MonoBehaviour
{
    public GameObject Abwarten;
    public GameObject BusWerbung;
    public GameObject Feier;
    public GameObject OnlineWerbung;
    public GameObject Plakate;
    public GameObject TvWerbung;
    public GameObject AutoWerbung;
    public GameObject Zeitung;
    public GameObject Zusatz;
    public Text werbungstext;
    public Text Kosten;
    public Text Cooldown;
    public Text Wasbringtes;
    public static int KostenInClass;
    public Button Sumbitbutton;

    public void Update()
    {
        if (KostenInClass > GlobalVariables.balance)
        {
            Sumbitbutton.interactable = false;
        }
        else
        {
            Sumbitbutton.interactable = true;
        }
    }


    public void Abwarten_1()
    {
        GlobalVariables.werbungsswitch = 1;
        werbungstext.text = "Das ist der Werbungstext für das Abwarten";
       
    }

    public void Buswerbung_2()
    {
        GlobalVariables.werbungsswitch = 2;
        werbungstext.text = "Buswerbung";
        KostenInClass = 20000;
        Kosten.text = "Diese Werbung kostet dich 20000€";
        Cooldown.text = "Du kannst diese Werbung alle 10 Tage schalten";
        Wasbringtes.text = "Du wirst ca. 10 Kunden dadurch gewinnen können";
    }
    public void Feier_3()
    {
        GlobalVariables.werbungsswitch = 3;
        werbungstext.text = "Feierlichkeiten";
        KostenInClass = 50000;
        Kosten.text = "Diese Werbung kostet dich 50000€";
        Cooldown.text = "Du kannst diese Werbung alle 10 Tage schalten";
        Wasbringtes.text = "Du wirst ca. 30 Kunden dadurch gewinnen können";
    }

    public void Online_4()
    {
        GlobalVariables.werbungsswitch = 4;
        werbungstext.text =  "Onlinewerbung";
        KostenInClass = 450000;
        Kosten.text = "Diese Werbung kostet dich 450000€";
        Cooldown.text = "Du kannst diese Werbung alle 10 Tage schalten";
        Wasbringtes.text = "Du wirst ca. 180 Kunden dadurch gewinnen können";
    }
    public void Plakate_5()
    {
        GlobalVariables.werbungsswitch = 5;
        werbungstext.text = "Plakatwerbung";
        KostenInClass = 10000;
        Kosten.text = "Diese Werbung kostet dich 10000€";
        Cooldown.text = "Du kannst diese Werbung alle 10 Tage schalten";
        Wasbringtes.text = "Du wirst ca. 5 Kunden dadurch gewinnen können";
    }
    public void TvWerbung_6()
    {
        GlobalVariables.werbungsswitch = 6;
        werbungstext.text = "TV-Werbung";
        KostenInClass = 300000;
        Kosten.text = "Diese Werbung kostet dich 300000€";
        Cooldown.text = "Du kannst diese Werbung alle 10 Tage schalten";
        Wasbringtes.text = "Du wirst ca. 120 Kunden dadurch gewinnen können";
    }
    public void Autowerbung_7()
    {
        GlobalVariables.werbungsswitch = 7;
        werbungstext.text = "Autowerbung";
        KostenInClass = 15000;
        Kosten.text = "Diese Werbung kostet dich 15000€";
        Cooldown.text = "Du kannst diese Werbung alle 10 Tage schalten";
        Wasbringtes.text = "Du wirst ca. 15 Kunden dadurch gewinnen können";
    }
    public void Zeitung_8()
    {
        GlobalVariables.werbungsswitch = 8;
        werbungstext.text = "Zeitung";
        KostenInClass = 5000;
        Kosten.text = "Diese Werbung kostet dich 5000€";
        Cooldown.text = "Du kannst diese Werbung alle 10 Tage schalten";
        Wasbringtes.text = "Du wirst ca. 5 Kunden dadurch gewinnen können";
    }
    public void Zusatz_9()
    {
        GlobalVariables.werbungsswitch = 9;
        werbungstext.text = "Das ist der Werbungstext für die Zusatz Werbung";
    }
}
