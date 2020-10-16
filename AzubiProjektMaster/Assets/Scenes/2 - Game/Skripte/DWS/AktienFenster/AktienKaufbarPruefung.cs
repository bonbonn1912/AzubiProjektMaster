using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;
using UnityEngine.UI;

public class AktienKaufbarPruefung : MonoBehaviour
{
    public GameObject InputFieldAktie1;
    public static int ValueInputField1;
    public static bool KaufenAktie1;

    public GameObject InputFieldAktie2;
    public static int ValueInputField2;
    public static bool KaufenAktie2;

    public GameObject InputFieldAktie3;
    public static int ValueInputField3;
    public static bool KaufenAktie3;

    public GameObject InputFieldAktie4;
    public static int ValueInputField4;
    public static bool KaufenAktie4;

    public GameObject InputFieldAktie5;
    public static int ValueInputField5;
    public static bool KaufenAktie5;

    public static int AmountAktie1 =1;
    public static int AmountAktie2 =1;
    public static int AmountAktie3 =1;
    public static int AmountAktie4 =1;
    public static int AmountAktie5 =1;

    public GameObject OrderVolumeAktie1;
    public GameObject OrderVolumenAktie2;
    public GameObject OrderVolumenAktie3;
    public GameObject OrderVolumenAktie4;
    public GameObject OrderVolumenAktie5;


    public void Update()
    {
        
        if (InputFieldAktie1.GetComponent<InputField>().text == "") 
        {
            if(1*GlobalVariables.Aktie1KursGlob> GlobalVariables.balance)
            {
                KaufenAktie1 = false;
                

            }
            else
            {
                KaufenAktie1 = true;
                ValueInputField1 = 1;
                
               // OrderVolumeAktie1.GetComponent<Text>().text = "Ordervolumen: AktienKurs €";
            }
        }
        else
        {
            ValueInputField1 = Convert.ToInt32(InputFieldAktie1.GetComponent<InputField>().text);
        }
       
        if (ValueInputField1 * GlobalVariables.Aktie1KursGlob > GlobalVariables.balance)
        {
            KaufenAktie1 = false;
            string value = Convert.ToString(GlobalVariables.Aktie1KursGlob * ValueInputField1);
            

        }
        else
        {
            KaufenAktie1 = true;
            AmountAktie1 = ValueInputField1;
            if (AmountAktie1 > 1)
            {
                string value = Convert.ToString(GlobalVariables.Aktie1KursGlob * ValueInputField1);
                OrderVolumeAktie1.GetComponent<Text>().text = "Ordervolumen Aktie1: " + value + " €";
            }
            
        }
        //____________________________________________________________________________________________________________________________________
        
        if (InputFieldAktie2.GetComponent<InputField>().text == "")
        {
            if (1 * GlobalVariables.Aktie2KursGlob > GlobalVariables.balance)
            {
                KaufenAktie2 = false;
                
            }
            else
            {
                KaufenAktie2 = true;
                ValueInputField2 = 1;
            }
        }
        else
        {
            ValueInputField2 = Convert.ToInt32(InputFieldAktie2.GetComponent<InputField>().text);
        }

        if (ValueInputField2 * GlobalVariables.Aktie2KursGlob > GlobalVariables.balance)
        {
            KaufenAktie2 = false;
        }
        else
        {
            KaufenAktie2 = true;
            AmountAktie2 = ValueInputField2;
            if (AmountAktie2 > 1)
            {
                string value = Convert.ToString(GlobalVariables.Aktie2KursGlob * ValueInputField2);
                OrderVolumenAktie2.GetComponent<Text>().text = "Ordervolumen Aktie2: " + value + " €";
            }
        }
        //_________________________________________________________________________________________________________________________________________________
        if (InputFieldAktie3.GetComponent<InputField>().text == "")
        {
            if (1 * GlobalVariables.Aktie3KursGlob > GlobalVariables.balance)
            {
                KaufenAktie3 = false;
                
            }
            else
            {
                KaufenAktie3 = true;
                ValueInputField3 = 1;
            }
        }
        else
        {
            ValueInputField3 = Convert.ToInt32(InputFieldAktie3.GetComponent<InputField>().text);
        }

        if (ValueInputField3 * GlobalVariables.Aktie3KursGlob > GlobalVariables.balance)
        {
            KaufenAktie3 = false;
        }
        else
        {
            KaufenAktie3 = true;
            AmountAktie3 = ValueInputField3;
            if (AmountAktie3 > 1)
            {
                string value = Convert.ToString(GlobalVariables.Aktie3KursGlob * ValueInputField3);
                OrderVolumenAktie3.GetComponent<Text>().text = "Ordervolumen Aktie3: " + value + " €";
            }
        }
        //_________________________________________________________________________________________________________________________________________________

        if (InputFieldAktie4.GetComponent<InputField>().text == "")
        {
            if (1 * GlobalVariables.Aktie4KursGlob > GlobalVariables.balance)
            {
                KaufenAktie4 = false;
               
            }
            else
            {
                KaufenAktie4 = true;
                ValueInputField4 = 1;

            }
        }
        else
        {
            ValueInputField4 = Convert.ToInt32(InputFieldAktie4.GetComponent<InputField>().text);
        }

        if (ValueInputField4 * GlobalVariables.Aktie4KursGlob > GlobalVariables.balance)
        {
            KaufenAktie4 = false;
        }
        else
        {
            KaufenAktie4 = true;
            AmountAktie4 = ValueInputField4;
            if (AmountAktie4 > 1)
            {
                string value = Convert.ToString(GlobalVariables.Aktie4KursGlob * ValueInputField4);
                OrderVolumenAktie4.GetComponent<Text>().text = "Ordervolumen Aktie4: " + value + " €";
            }
        }
        //_________________________________________________________________________________________________________________________________________________
        if (InputFieldAktie5.GetComponent<InputField>().text == "")
        {
            if (1 * GlobalVariables.Aktie5KursGlob > GlobalVariables.balance)
            {
                KaufenAktie5 = false;

            }
            else
            {
                KaufenAktie5 = true;
                ValueInputField5 = 1;

            }
        }
        else
        {
            ValueInputField5 = Convert.ToInt32(InputFieldAktie5.GetComponent<InputField>().text);
        }

        if (ValueInputField5 * GlobalVariables.Aktie5KursGlob > GlobalVariables.balance)
        {
            KaufenAktie5 = false;
        }
        else
        {
            KaufenAktie5 = true;
            AmountAktie5 = ValueInputField5;
            if (AmountAktie5 > 1)
            {
                string value = Convert.ToString(GlobalVariables.Aktie5KursGlob * ValueInputField5);
                OrderVolumenAktie5.GetComponent<Text>().text = "Ordervolumen Aktie5: " + value + " €";
            }
        }
        //_________________________________________________________________________________________________________________________________________________









    }


}
