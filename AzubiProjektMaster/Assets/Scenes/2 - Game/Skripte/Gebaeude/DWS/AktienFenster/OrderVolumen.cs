using System.Collections;
using System.Collections.Generic;
using System.Security;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OrderVolumen : MonoBehaviour
{
    int value1 = 0;
    int value2 = 0;
    int value3 = 0;
    int value4 = 0;
    int value5 = 0;
    public GameObject OrderVolumenAktie1;
    public GameObject OrdervolumenAktie2;
    public GameObject OrderVolumenAktie3;
    public GameObject OrderVolumenAktie4;
    public GameObject OrderVolumenAktie5;
    public GameObject OrderVolumenAktie6;

    public GameObject placerholder1;
    public GameObject placerholder2;
    public GameObject placerholder3;
    public GameObject placerholder4;
    public GameObject placerholder5;
    public GameObject VolumenText;

    public void Update()

    {
        value1 = AktienKaufbarPruefung.ValueInputField1;
        value2 = AktienKaufbarPruefung.ValueInputField2;
        value3 = AktienKaufbarPruefung.ValueInputField3;
        value4 = AktienKaufbarPruefung.ValueInputField4;
        value5 = AktienKaufbarPruefung.ValueInputField5;
    }
    public void setplaceholder1()
    {
        // placerholder.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "244";
        placerholder2.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder3.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder4.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder5.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder2.GetComponent<InputField>().text = "";
        placerholder3.GetComponent<InputField>().text = "";
        placerholder4.GetComponent<InputField>().text = "";
        placerholder5.GetComponent<InputField>().text = "";
        VolumenText.GetComponent<Text>().text = "Aktie 1 ausgewählt";
    }
    public void setplace2holder2()
    {
        placerholder1.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder3.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder4.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder5.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder1.GetComponent<InputField>().text = "";
        placerholder3.GetComponent<InputField>().text = "";
        placerholder4.GetComponent<InputField>().text = "";
        placerholder5.GetComponent<InputField>().text = "";
        VolumenText.GetComponent<Text>().text = "Aktie 2 ausgewählt";
    }
    public void setplace2holder3()
    {
        placerholder1.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder2.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder4.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder5.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder1.GetComponent<InputField>().text = "";
        placerholder2.GetComponent<InputField>().text = "";
        placerholder4.GetComponent<InputField>().text = "";
        placerholder5.GetComponent<InputField>().text = "";
        VolumenText.GetComponent<Text>().text = "Aktie 3 ausgewählt";
    }
    public void setplace2holder4()
    {
        placerholder1.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder2.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder3.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder5.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder1.GetComponent<InputField>().text = "";
        placerholder2.GetComponent<InputField>().text = "";
        placerholder3.GetComponent<InputField>().text = "";
        placerholder5.GetComponent<InputField>().text = "";
        VolumenText.GetComponent<Text>().text = "Aktie 4 ausgewählt";
    }
    public void setplace2holder5()
    {
        placerholder1.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder2.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder3.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder4.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "1";
        placerholder1.GetComponent<InputField>().text = "";
        placerholder2.GetComponent<InputField>().text = "";
        placerholder3.GetComponent<InputField>().text = "";
        placerholder4.GetComponent<InputField>().text = "";
        VolumenText.GetComponent<Text>().text = "Aktie 5 ausgewählt";
    }

    public void OrderVolumenAktie1Trigger()
    {
        int sum = value1 * GlobalVariables.Aktie1KursGlob;
        OrderVolumenAktie1.GetComponent<Text>().enabled = true;
        OrderVolumenAktie3.GetComponent<Text>().enabled =false;
        OrderVolumenAktie4.GetComponent<Text>().enabled = false;
        OrderVolumenAktie5.GetComponent<Text>().enabled = false;
        OrdervolumenAktie2.GetComponent<Text>().enabled = false;
        OrderVolumenAktie6.GetComponent<Text>().enabled = false;

      

        // OrderVolumenAktie1.GetComponent<Text>().text = "Ordervolumen für Aktie1: "+sum+" €";
    }
    public void OrderVolumenAktie2Trigger()
    {
        int sum = value2 * GlobalVariables.Aktie2KursGlob;
        OrdervolumenAktie2.GetComponent<Text>().enabled = true;
        OrderVolumenAktie1.GetComponent<Text>().enabled = false;
        OrderVolumenAktie3.GetComponent<Text>().enabled = false;
        OrderVolumenAktie4.GetComponent<Text>().enabled = false;
        OrderVolumenAktie5.GetComponent<Text>().enabled = false;
        OrderVolumenAktie6.GetComponent<Text>().enabled = false;
      
        //  OrdervolumenAktie2.GetComponent<Text>().text = "MOmentan in Aktie 2 Feld";
        //   OrdervolumenAktie2.GetComponent<Text>().text = "Ordervolumen für Aktie2: " + sum + " €";
    }
    public void OrderVolumenAktie3Trigger()
    {
        int sum = value3 * GlobalVariables.Aktie3KursGlob;
        OrdervolumenAktie2.GetComponent<Text>().enabled = false;
        OrderVolumenAktie1.GetComponent<Text>().enabled = false;
        OrderVolumenAktie3.GetComponent<Text>().enabled = true;
        OrderVolumenAktie4.GetComponent<Text>().enabled = false;
        OrderVolumenAktie5.GetComponent<Text>().enabled = false;
        OrderVolumenAktie6.GetComponent<Text>().enabled = false;
       
        //  OrderVolumenAktie3.GetComponent<Text>().text = "Ordervolumen für Aktie3: " + sum + " €";
    }
    public void OrderVolumenAktie4Trigger() {
        int sum = value4 * GlobalVariables.Aktie4KursGlob;
        OrdervolumenAktie2.GetComponent<Text>().enabled = false;
        OrderVolumenAktie1.GetComponent<Text>().enabled = false;
        OrderVolumenAktie3.GetComponent<Text>().enabled = false;
        OrderVolumenAktie4.GetComponent<Text>().enabled = true;
        OrderVolumenAktie5.GetComponent<Text>().enabled = false;
        OrderVolumenAktie6.GetComponent<Text>().enabled = false;
     
        //   OrderVolumenAktie3.GetComponent<Text>().text = "Ordervolumen für Aktie4: " + sum + " €";
    }
    
    
    public void OrderVolumenAktie5Trigger()
    {
        int sum = value5 * GlobalVariables.Aktie5KursGlob;
        OrdervolumenAktie2.GetComponent<Text>().enabled = false;
        OrderVolumenAktie1.GetComponent<Text>().enabled = false;
        OrderVolumenAktie3.GetComponent<Text>().enabled = false;
        OrderVolumenAktie4.GetComponent<Text>().enabled = false;
        OrderVolumenAktie5.GetComponent<Text>().enabled = true;
        OrderVolumenAktie6.GetComponent<Text>().enabled = false;
     
        // OrderVolumenAktie3.GetComponent<Text>().text = "Ordervolumen für Aktie5: " + sum + " €";
    }

    public void DefaultOrderVolumen()
    {
        OrdervolumenAktie2.GetComponent<Text>().enabled = false;
        OrderVolumenAktie1.GetComponent<Text>().enabled = false;
        OrderVolumenAktie3.GetComponent<Text>().enabled = false;
        OrderVolumenAktie4.GetComponent<Text>().enabled = false;
        OrderVolumenAktie5.GetComponent<Text>().enabled = false;
        OrderVolumenAktie6.GetComponent<Text>().enabled = true;
        OrderVolumenAktie6.GetComponent<Text>().text = "Order Volumen: Aktienkurs";
    }


}
