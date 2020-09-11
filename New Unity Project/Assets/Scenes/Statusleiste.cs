using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statusleiste : MonoBehaviour
{
    //Statusleiste
    public Text textFieldBalance;
    public Text textFieldDate;

    void Update()
    {
        textFieldBalance.text = GlobalVariables.balance.ToString();
        textFieldDate.text = GlobalVariables.day.ToString();
    }
}
