using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSetzen : MonoBehaviour
{
    public Button KaufenAktie1;
    public Button KaufenAktie2;
    public Button KaufenAktie3;
    public Button KaufenAktie4;
    public Button KaufenAktie5;

    public Button VerkaufenAktie1;
    public Button VerkaufenAktie2;
    public Button VerkaufenAktie3;
    public Button VerkaufenAktie4;
    public Button VerkaufenAktie5;

    public GameObject closeTablet;

    public void CloseTablet()
    {
        closeTablet.SetActive(!closeTablet.activeSelf);
    }
    // Update is called once per frame
    void Update()
    {
        if(AktienKaufbarPruefung.KaufenAktie1 == true)
        {
            KaufenAktie1.interactable = true;
        }
        else
        {
            KaufenAktie1.interactable = false;
        }
        //____________________________________
        if (AktienKaufbarPruefung.KaufenAktie2 == true)
        {
            KaufenAktie2.interactable = true;
        }
        else
        {
            KaufenAktie2.interactable = false;
        }
        //____________________________________
        if (AktienKaufbarPruefung.KaufenAktie3 == true)
        {
            KaufenAktie3.interactable = true;
        }
        else
        {
            KaufenAktie3.interactable = false;
        }
        //____________________________________
        if (AktienKaufbarPruefung.KaufenAktie4 == true)
        {
            KaufenAktie4.interactable = true;
        }
        else
        {
            KaufenAktie4.interactable = false;
        }
        //____________________________________
        if (AktienKaufbarPruefung.KaufenAktie5 == true)
        {
            KaufenAktie5.interactable = true;
        }
        else
        {
            KaufenAktie5.interactable = false;
        }
        //____________________________________
        if(AktienVerkaufbarPruefung.VerkaufenAktie1 == true)
        {
            VerkaufenAktie1.interactable = true;
        }
        else
        {
            VerkaufenAktie1.interactable = false;
        }
        //_____________________________________
        if (AktienVerkaufbarPruefung.VerkaufenAktie2 == true)
        {
            VerkaufenAktie2.interactable = true;
        }
        else
        {
            VerkaufenAktie2.interactable = false;
        }
        //_____________________________________
        if (AktienVerkaufbarPruefung.VerkaufenAktie3 == true)
        {
            VerkaufenAktie3.interactable = true;
        }
        else
        {
            VerkaufenAktie3.interactable = false;
        }
        //_____________________________________
        if (AktienVerkaufbarPruefung.VerkaufenAktie4 == true)
        {
            VerkaufenAktie4.interactable = true;
        }
        else
        {
            VerkaufenAktie4.interactable = false;
        }
        //_____________________________________
        if (AktienVerkaufbarPruefung.VerkaufenAktie5 == true)
        {
            VerkaufenAktie5.interactable = true;
        }
        else
        {
            VerkaufenAktie5.interactable = false;
        }
        //_____________________________________
    }
}
