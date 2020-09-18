﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHRpopup : MonoBehaviour
{
    public GameObject FAPopUp;
    public void OpenPanel()
    {
        if (FAPopUp != null)
        {
            bool isActive = FAPopUp.activeSelf;
            FAPopUp.SetActive(!isActive);
        }
    }
}
