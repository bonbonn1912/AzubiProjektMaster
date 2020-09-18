using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScene : MonoBehaviour
{
    public Button logOut;
    public Text usernameText;
    public Button GebaeudeKaufen;
    public Button Werbung;
    
    // Start is called before the first frame update
    void Start()
    {
        usernameText.text = GlobalVariables.username;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LogOut()
    {
        GlobalVariables.username = null;
        SceneManager.LoadScene(0);
    }
    public void LoadMitarbeiter()
    {
        SceneManager.LoadScene(4);
    }
   
    public void clickInGebaeudeKaufen()
    {
        SceneManager.LoadScene(5);
    }
    public void clickWerbung()
    {
        SceneManager.LoadScene(6);
    }
}
