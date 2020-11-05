﻿using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Login : MonoBehaviour
{
  
    public InputField NameInputField;
    public InputField PWInputField;
    public DailyUpdate init;
    public Text dbReply;
    public Button LoginButton;
    public Button backToMenu;

    private int tabSelect;
    public void Start()
    {
        LoginButton.interactable = false;
        if(GlobalVariables.registrationResult != null)
        {
            dbReply.text = GlobalVariables.registrationResult;
        }
        if (Registration.completet && Registration.user != null)
        {
            NameInputField.GetComponent<InputField>().text = Registration.user;
            PWInputField.GetComponent<InputField>().Select();
            Registration.user = null;
        }
        else
        {
            NameInputField.GetComponent<InputField>().Select();
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (tabSelect == 2)
            {
                tabSelect = 0;
            }
            else
            {
                tabSelect += 1;
            }
            switch (tabSelect)
            {
                case 0:
                    FadeToColor(LoginButton, LoginButton.colors.normalColor);
                    NameInputField.GetComponent<InputField>().Select();
                    break;
                case 1:
                    PWInputField.GetComponent<InputField>().Select();
                    break;
                case 2:
                    EventSystem.current.SetSelectedGameObject(null);
                    FadeToColor(LoginButton, LoginButton.colors.pressedColor);
                    break;
                default:
                    Debug.Log("Hard to count from 0, huh?");
                    break;
            }
        }
        else if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            if (LoginButton.IsInteractable())
            {
                LoginButton.onClick.Invoke();
                LoginButton.GetComponent<AudioSource>().Play();
            }
            else
            {
                LoginButton.GetComponent<AudioSource>().Play();
            }
        }
    }
    public void FadeToColor(Button button, Color color)
    {
        Graphic graphic = button.GetComponent<Graphic>();
        graphic.CrossFadeColor(color, button.colors.fadeDuration, true, true);
    }

    public void CallLogin()
    {
        if (NameInputField.text.Length >= 8 && PWInputField.text.Length >= 8)
        {
            StartCoroutine(StartLogin());
        }
        else
        {
            dbReply.text = "Nutzername & Passwort müssen min. 8 Zeichen haben!";
        }
    }
    IEnumerator StartLogin()
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();
        WWWForm form = new WWWForm();
        form.AddField("name", NameInputField.text);
       // Debug.Log("Übergebener Name: " + NameInputField.text);
        form.AddField("password", PWInputField.text);

        // WWW www = new WWW("http://localhost/sqlconnection/sqlconnect/login.php", form);
          WWW www = new WWW("https://dominikw.de/AzubiProjekt/loginDEV.php", form);
        // WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/loginDEV.php", form);
        yield return www;
        if (www.text == "0")
        {
            GlobalVariables.username = NameInputField.text;
           // init.Init();
            UnityEngine.SceneManagement.SceneManager.LoadScene(3);
            watch.Stop();
                float ms = watch.ElapsedMilliseconds;
           // Debug.Log("Login Dauer: " +ms+ " ms");
      

        }
        else
        {
            dbReply.text = www.text;   
        }
       
    }
    public void VerifyInputs()
    {
        LoginButton.interactable = (NameInputField.text.Length >= 1 && PWInputField.text.Length >= 1);
        if (NameInputField.text.Length >= 8 && PWInputField.text.Length >= 8)
        {
            FadeToColor(LoginButton, LoginButton.colors.normalColor);
        }
        else
        {
            FadeToColor(LoginButton, LoginButton.colors.disabledColor);
        }
    }
    public void BackToMenu() 
    {
        NameInputField.GetComponent<InputField>().text = null;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
