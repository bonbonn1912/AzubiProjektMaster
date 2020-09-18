using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour

{
    public InputField NameInputField;
    public InputField PWInputField;

    public Button submitButton;
    public Text dbReply;

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
        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/register.php", form);
        yield return www;
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

        // WWW www = new WWW("https://dominikw.de/AzubiProjekt/anlegen.php", form);
        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/anlegen.php", form);
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
