using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScene : MonoBehaviour
{
    public Button logOut;
    public Text LoggedInText;
    
    // Start is called before the first frame update
    void Start()
    {
            LoggedInText.text = GlobalVariables.username;
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
}
