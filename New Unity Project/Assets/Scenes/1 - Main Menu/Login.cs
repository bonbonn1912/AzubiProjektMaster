using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
public class Login : MonoBehaviour
{
  
    public InputField NameInputField;
    public InputField PWInputField;
    public DailyUpdate init;
    public Text dbReply;
    public Button LoginButton;
    public Button backToMenu;

    public void Start()
    {
        LoginButton.interactable = false;
        if(GlobalVariables.registrationResult != null)
        {
            dbReply.text = GlobalVariables.registrationResult;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (NameInputField.GetComponent<InputField>().isFocused)
            {
                PWInputField.GetComponent<InputField>().Select();
            }
            if (PWInputField.GetComponent<InputField>().isFocused)
            {
                NameInputField.GetComponent<Button>().Select();
            }
        }
    }

    public void CallLogin()
    {
        StartCoroutine(StartLogin());
    }
    IEnumerator StartLogin()
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();
        WWWForm form = new WWWForm();
        form.AddField("name", NameInputField.text);
       // Debug.Log("Übergebener Name: " + NameInputField.text);
        form.AddField("password", PWInputField.text);

        // WWW www = new WWW("http://localhost/sqlconnection/sqlconnect/login.php", form);
        // WWW www = new WWW("https://dominikw.de/AzubiProjekt/login.php", form);
        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/login.php", form);
        yield return www;
        if (www.text == "0")
        {
            GlobalVariables.username = NameInputField.text;
            init.Init();
            UnityEngine.SceneManagement.SceneManager.LoadScene(3);
            watch.Stop();
                float ms = watch.ElapsedMilliseconds;
            Debug.Log("Login Dauer: " +ms+ " ms");
        }
        else
        {
            dbReply.text = www.text;   
        }
       
    }
    public void VerifyInputs()
    {
        LoginButton.interactable = (NameInputField.text.Length >= 1 && PWInputField.text.Length >= 1);
    }
    public void BackToMenu() 
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
