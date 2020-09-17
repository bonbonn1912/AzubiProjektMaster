using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour {

    public Text playerDisplay;
  

    private void Start()
     {
        if (GlobalVariables.LoggedIn)
        {
            playerDisplay.text = "Player:" + GlobalVariables.username;
        }
     }

    // Start is called before the first frame update
    public void GoToRegister()
    {
      
        SceneManager.LoadScene(1);

    }

    public void GoToLogin()
    {
       
        SceneManager.LoadScene(2);
    }

    public void GoToGame()
    {
        
        GlobalVariables.username = "AdminMuHaHaHa";
        SceneManager.LoadScene(3);
    }

    public void LeaveGame()
    {
        Application.Quit();
    }
}
