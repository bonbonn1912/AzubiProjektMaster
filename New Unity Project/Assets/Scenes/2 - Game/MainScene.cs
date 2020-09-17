using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScene : MonoBehaviour
{
    public Button logOut;
    public Text usernameText;
    
    // Start is called before the first frame update
    void Start()
    {
        usernameText.text = "Username: " + GlobalVariables.username;
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
   
}
