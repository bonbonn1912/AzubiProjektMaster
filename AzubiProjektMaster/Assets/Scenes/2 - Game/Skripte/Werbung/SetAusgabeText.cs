using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetAusgabeText : MonoBehaviour
{
    public TextMeshProUGUI AusgabeText;
    public GameObject AbwartenButton;
    public GameObject BuswerbungButton;
    public GameObject PlakateButton;
    public GameObject TVWerbungButton;
    public GameObject WerbeautoButton;
    public GameObject OnlinewerbungButton;
    public GameObject ZusatzkonditionenButton;
    public GameObject ZeitungswerbungButton;
    public GameObject EröffnungsfeierButton;
    public GameObject BoniButton;
    
    public void setAusgabeTextAbwarten()
    {
        AusgabeText.text = "abwarten";
        AbwartenButton.SetActive(true);
    }

    public void SetAusgabeTextBuswerbung()
    {
        AusgabeText.text = "buswerbung";
        BuswerbungButton.SetActive(true);
    }

    public void SetAusgabeTextPlakate()
    {
        AusgabeText.text = "plakate";
        PlakateButton.SetActive(true);
    }

    public void SetAusgabeTextTvwerbung()
    {
        AusgabeText.text = "tvwerbung";
        TVWerbungButton.SetActive(true);
    }

    public void SetAusgabeTextWerbeauto()
    {
        AusgabeText.text = "werbeauto";
        WerbeautoButton.SetActive(true);
    }

    public void SetAusgabeTextOnlinewerbung()
    {
        AusgabeText.text = "onlinewerbung";
        OnlinewerbungButton.SetActive(true);
    }

    public void SetAusgabeTextZusatzkonditionen()
    {
        AusgabeText.text = "zusatzkonditonen";
        ZusatzkonditionenButton.SetActive(true);
    }

    public void SetAusgabeTextZeitungswerbung()
    {
        AusgabeText.text = "zeitungswerbung";
        ZeitungswerbungButton.SetActive(true);
    }

    public void SetAusgabeTextEröffnungsfeier()
    {
        AusgabeText.text = "eröffnungsfeier";
        EröffnungsfeierButton.SetActive(true);
    }

    public void setAusgabeTextBoni()
    {
        AusgabeText.text = "boni";
        BoniButton.SetActive(true);
    }
}
