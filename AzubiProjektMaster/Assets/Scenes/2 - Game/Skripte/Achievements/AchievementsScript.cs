using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementsScript : MonoBehaviour
{
    public GameObject AchievementsTablet;

    public void OpenAchievements()
    {
        if (AchievementsTablet != null)
        {
            //Debug.Log("Tablet triggered");
            bool isActive = AchievementsTablet.activeSelf;
            AchievementsTablet.SetActive(!isActive);
            MainScene.TabletHandlerActivate();
        }
    }

    public void CloseAchievements()
    {
        bool isActive = AchievementsTablet.activeSelf;
        AchievementsTablet.SetActive(isActive);
    }
}