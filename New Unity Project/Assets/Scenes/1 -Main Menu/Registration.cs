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
        WWW www = new WWW("https://dominikw.de/AzubiProjekt/register.php", form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("User created successfully");
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
            StartCoroutine(AccountAnlegen());
        }
        else
        {
            dbReply.text = "Error: " + www.text;
            Debug.Log("User creation failed. Error#:" + www.text);
        }
    }
    IEnumerator AccountAnlegen()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", NameInputField.text);
        form.AddField("balance", GlobalVariables.startkapital);
        form.AddField("employees", GlobalVariables.mitarbeiterStart);
        form.AddField("buildings", GlobalVariables.buildingsStart);

        WWW www = new WWW("https://dominikw.de/AzubiProjekt/anlegen.php", form);
        yield return www;
        Debug.Log("Nach anlegen: " + www.text);
        if (www.text == "0")
        {
            GlobalVariables.registrationResult = "Registration Successfull";
        }
    }
    public void VerifyInputs()
    {
        submitButton.interactable = (NameInputField.text.Length >= 8 && PWInputField.text.Length >= 8);
        if (!submitButton.interactable)
        {
            dbReply.text = "Username and password must be min. 8 characters long";
        }
        else
        {
            dbReply.text = "";
        }
    }
    public void BackToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
