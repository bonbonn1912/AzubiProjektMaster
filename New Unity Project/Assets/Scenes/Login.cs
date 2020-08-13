using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Login : MonoBehaviour
{
    public InputField NameInputField;
    public InputField PWInputField;

    public Button submitButton;

    public void CallLogin()
    {
        StartCoroutine(StartLogin());
    }

    IEnumerator StartLogin()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", NameInputField.text);
        form.AddField("password", PWInputField.text);

        WWW www = new WWW("http://localhost/sqlconnect/login.php", form);
        yield return www;
        if (www.text[0] == '0')
        {
            DBManager.username = NameInputField.text;
            DBManager.score = int.Parse(www.text.Split('\t')[1]);
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else
        {
            Debug.Log("User login failed"+ www.text);
        }
       
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (NameInputField.text.Length >= 8 && PWInputField.text.Length >= 8);
        Debug.Log(DBManager.score);
    }
}
