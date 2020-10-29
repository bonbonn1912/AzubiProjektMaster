using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AktienVerkaufbarPruefung : MonoBehaviour
{
    public Text AnzahlAktie1imDepot;
    public GameObject InputFieldAktie1;
    public static bool VerkaufenAktie1;
    int valueInputField1;

    public Text AnzahlAktie2imDepot;
    public GameObject InputFieldAktie2;
    public static bool VerkaufenAktie2;
    int valueInputField2;

    public Text AnzahlAktie3imDepot;
    public GameObject InputFieldAktie3;
    public static bool VerkaufenAktie3;
    int valueInputField3;

    public Text AnzahlAktie4imDepot;
    public GameObject InputFieldAktie4;
    public static bool VerkaufenAktie4;
    int valueInputField4;

    public Text AnzahlAktie5imDepot;
    public GameObject InputFieldAktie5;
    public static bool VerkaufenAktie5;
    int valueInputField5;

    public static int AmountimDepotAktie1;
    public static int AmountimDepotAktie2;
    public static int AmountimDepotAktie3;
    public static int AmountimDepotAktie4;
    public static int AmountimDepotAktie5;


    private void Update()
    {
        if(InputFieldAktie1.GetComponent<InputField>().text == "")
        {
            valueInputField1 = 1;
        }
        else
        {
            valueInputField1 = Convert.ToInt32(InputFieldAktie1.GetComponent<InputField>().text);
        }
        AmountimDepotAktie1 = valueInputField1;
            
           
        if(Convert.ToInt32(AnzahlAktie1imDepot.text)>= valueInputField1)
        {
            VerkaufenAktie1 = true;
        }
        else
        {
            VerkaufenAktie1 = false;
        }
        //______________________________________________________________________________________________
        if (InputFieldAktie2.GetComponent<InputField>().text == "")
        {
            valueInputField2 = 1;
        }
        else
        {
            valueInputField2 = Convert.ToInt32(InputFieldAktie2.GetComponent<InputField>().text);
        }

        AmountimDepotAktie2 = valueInputField2;

        if (Convert.ToInt32(AnzahlAktie2imDepot.text) >= valueInputField2)
        {
            VerkaufenAktie2 = true;
        }
        else
        {
            VerkaufenAktie2 = false;
        }
        //______________________________________________________________________________________________
        if (InputFieldAktie3.GetComponent<InputField>().text == "")
        {
            valueInputField3 = 1;
        }
        else
        {
            valueInputField3 = Convert.ToInt32(InputFieldAktie3.GetComponent<InputField>().text);
        }
        AmountimDepotAktie3 = valueInputField3;


        if (Convert.ToInt32(AnzahlAktie3imDepot.text) >= valueInputField3)
        {
            VerkaufenAktie3= true;
        }
        else
        {
            VerkaufenAktie3= false;
        }
        //______________________________________________________________________________________________
        if (InputFieldAktie4.GetComponent<InputField>().text == "")
        {
            valueInputField4 = 1;
        }
        else
        {
            valueInputField4 = Convert.ToInt32(InputFieldAktie4.GetComponent<InputField>().text);
        }

        AmountimDepotAktie4 = valueInputField4;

        if (Convert.ToInt32(AnzahlAktie4imDepot.text) >= valueInputField4)
        {
            VerkaufenAktie4 = true;
        }
        else
        {
            VerkaufenAktie4 = false;
        }
        //______________________________________________________________________________________________
        if (InputFieldAktie5.GetComponent<InputField>().text == "")
        {
            valueInputField5 = 1;
        }
        else
        {
            valueInputField5 = Convert.ToInt32(InputFieldAktie5.GetComponent<InputField>().text);
        }

        AmountimDepotAktie5 = valueInputField5;

        if (Convert.ToInt32(AnzahlAktie5imDepot.text) >= valueInputField5)
        {
            VerkaufenAktie5 = true;
        }
        else
        {
            VerkaufenAktie5 = false;
        }
        //______________________________________________________________________________________________



    }
}
