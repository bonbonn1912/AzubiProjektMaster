using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statusleiste : MonoBehaviour
{
    //Statusleiste
    public Text textFieldBalance;
    public Text textFieldDay;

    void Update()
    {
        textFieldBalance.text = GlobalVariables.balance.ToString();
        textFieldDay.text = GlobalVariables.day.ToString();
    }
}
