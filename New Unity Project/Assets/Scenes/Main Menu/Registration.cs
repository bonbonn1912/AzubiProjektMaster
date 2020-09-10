using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour

{
    public InputField NameInputField;
    public InputField PWInputField;

    public Button submitButton;

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
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            StartCoroutine(AccountAnlegen());
        }
        else
        {
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
