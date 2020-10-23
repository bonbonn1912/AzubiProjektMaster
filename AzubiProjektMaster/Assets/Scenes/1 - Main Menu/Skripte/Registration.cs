using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Registration : MonoBehaviour

{
    public InputField NameInputField;
    public InputField PWInputField;

    public Text FeedbackUsername;

    public GameObject PwFeedbackPanel;
    public Text PwFeedbackText;

  // public Image pwpanel;

    public Color Low;
    public Color Medium;
    public Color High;

    public Button submitButton;
    public Text dbReply;

    public MainMenu mainMenu;

    private int tabSelect;
    private void Start()
    {
        Low.a = 0f;
        PwFeedbackPanel.GetComponent<Image>().color = Low;
        PwFeedbackText.text = "";
        NameInputField.GetComponent<InputField>().Select();
    }
    public void Update()
    {
        if(PWInputField.GetComponent<InputField>().text.Length > 0 && PWInputField.GetComponent<InputField>().text.Length < 8)
        {
            Low.a = 0.1f;
            PwFeedbackPanel.GetComponent<Image>().color = Low;
            PwFeedbackText.text = "Schwach";
        }

        if (PWInputField.GetComponent<InputField>().text.Length > 7 && PWInputField.GetComponent<InputField>().text.Length < 10)
        {
            Medium.a = 0.1f;
            PwFeedbackPanel.GetComponent<Image>().color = Medium;
            PwFeedbackText.text = "Stark";
        }

        if (PWInputField.GetComponent<InputField>().text.Length  < 1)
        {
            Low.a = 0f;
            PwFeedbackPanel.GetComponent<Image>().color = Low;
            PwFeedbackText.text = "";
        }

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
                    mainMenu.FadeToColor(submitButton, submitButton.colors.normalColor);
                    NameInputField.GetComponent<InputField>().Select();
                    break;
                case 1:
                    PWInputField.GetComponent<InputField>().Select();
                    break;
                case 2:
                    EventSystem.current.SetSelectedGameObject(null);
                    mainMenu.FadeToColor(submitButton, submitButton.colors.pressedColor);
                    break;
                default:
                    Debug.Log("Hard to count from 0, huh?");
                    break;
            }
        }
        else if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            if (submitButton.IsInteractable())
            {
                submitButton.onClick.Invoke();
                submitButton.GetComponent<AudioSource>().Play();
            }
            else
            {
                submitButton.GetComponent<AudioSource>().Play();
            }
        }
    }

    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", NameInputField.text);
        form.AddField("password", PWInputField.text);

        // WWW www = new WWW("http://localhost/sqlconnection/sqlconnect/register.php", form);
        // WWW www = new WWW("https://dominikw.de/AzubiProjekt/register.php", form);
       //WW www = new WWW("https://dominikw.de/AzubiProjekt/registerDEV.php", form);
         WWW www = new WWW("https://dominikw.de/AzubiProjekt/registerDEV.php", form);
        // WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/registerDEV.php", form);
        // WWW www = new WWW("https://dominik.grandpa-kitchen.com/httpdocs/PHP-Skripte/registerDEV.php", form);
      
        yield return www;
        Debug.Log("register wwwtext" + www.text);
        if (www.text == "0")
        {   
            yield return StartCoroutine(AccountAnlegen());
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
        else
        {
            dbReply.text = www.text;
        }
    }
    IEnumerator AccountAnlegen()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", NameInputField.text);
        form.AddField("balance", GlobalVariables.startkapital);
        form.AddField("employees", GlobalVariables.mitarbeiterStart);
        form.AddField("buildings", GlobalVariables.buildingsStart);

         WWW www = new WWW("https://dominikw.de/AzubiProjekt/anlegenDEV.php", form);
        // WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/anlegen.php", form);
       // WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/anlegenDEV.php", form);
       // WWW www = new WWW("https://dominik.grandpa-kitchen.com/httpdocs/PHP-Skripte/anlegenDEV.php", form);
        yield return www;
        if (www.text == "0")
        {
            GlobalVariables.registrationResult = "Registration erfolgreich!\nBitte einloggen.";
        }
        else
        {
            GlobalVariables.registrationResult = www.text;
        }
    }
    public void VerifyInputs()
    {
        submitButton.interactable = (NameInputField.text.Length >= 8 && PWInputField.text.Length >= 8);
    }
    public void BackToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
