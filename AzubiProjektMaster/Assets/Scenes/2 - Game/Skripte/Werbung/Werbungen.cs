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


    public void Abwarten_1()
    {
        GlobalVariables.werbungsswitch = 1;
        werbungstext.text = "Das ist der Werbungstext für das Abwarten";
    }

    public void Buswerbung_2()
    {
        GlobalVariables.werbungsswitch = 2;
        werbungstext.text = "Das ist der Werbungstext für die Buswerbung";
    }
    public void Feier_3()
    {
        GlobalVariables.werbungsswitch = 3;
        werbungstext.text = "Das ist der Werbungstext für die Feier";
    }

    public void Online_4()
    {
        GlobalVariables.werbungsswitch = 4;
        werbungstext.text = "Das ist der Werbungstext für die Online Werbung";
    }
    public void Plakate_5()
    {
        GlobalVariables.werbungsswitch = 5;
        werbungstext.text = "Das ist der Werbungstext für die Plakate";
    }
    public void TvWerbung_6()
    {
        GlobalVariables.werbungsswitch = 6;
        werbungstext.text = "Das ist der Werbungstext für die TvWerbung";
    }
    public void Autowerbung_7()
    {
        GlobalVariables.werbungsswitch = 7;
        werbungstext.text = "Das ist der Werbungstext für die Autowerbung";
    }
    public void Zeitung_8()
    {
        GlobalVariables.werbungsswitch = 8;
        werbungstext.text = "Das ist der Werbungstext für Werbung in er Zeitung";
    }
    public void Zusatz_9()
    {
        GlobalVariables.werbungsswitch = 9;
        werbungstext.text = "Das ist der Werbungstext für die Zusatz Werbung";
    }
}
