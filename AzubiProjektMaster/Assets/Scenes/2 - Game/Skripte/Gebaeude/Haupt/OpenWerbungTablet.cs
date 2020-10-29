using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWerbungTablet : MonoBehaviour
{
    public GameObject Werbungstablet;
  
    public void OpenWerbungsTablet()
    {
        if (Werbungstablet != null)
        {
            Werbungstablet.SetActive(!Werbungstablet.activeSelf);
        }
        MainScene.TabletHandlerActivate();

    }
}
