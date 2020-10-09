using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WerbungBestätigen : MonoBehaviour
{
    public GameObject WerbungInfo;
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

    private void Start()
    {
        WerbungInfo.SetActive(false);
        AbwartenButton.SetActive(false);
        BuswerbungButton.SetActive(false);
        PlakateButton.SetActive(false);
        TVWerbungButton.SetActive(false);
        WerbeautoButton.SetActive(false);
        OnlinewerbungButton.SetActive(false);
        ZusatzkonditionenButton.SetActive(false);
        ZeitungswerbungButton.SetActive(false);
        EröffnungsfeierButton.SetActive(false);
        BoniButton.SetActive(false);
    }

    public void WerbungCanvasSetActive()
    {
        if (WerbungInfo.activeSelf == false)
        WerbungInfo.SetActive(true);
    }
}
