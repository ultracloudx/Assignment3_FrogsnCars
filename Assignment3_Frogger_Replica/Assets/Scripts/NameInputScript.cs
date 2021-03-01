using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class NameInputScript : MonoBehaviour
{
    public string userNameInput;
    public GameObject inputField;
    public GameObject textDisplay;
    public Text noNamePopUp;
    public Text changeNext;
    public Button enterButton;

    //private bool nameCheck = false;

    public void StoreName()
    {
        userNameInput = inputField.GetComponent<Text>().text;
        Debug.Log(userNameInput); //Code Testing
        if (userNameInput == "")
        {
            noNamePopUp.enabled = true;
            noNamePopUp.GetComponent<Text>().text = "No name entered!";
            enterButton.enabled = false;
        }
        else
        {
            //if(noNamePopUp.enabled == true) { noNamePopUp.enabled = false; }
            noNamePopUp.enabled = true;
            noNamePopUp.GetComponent<Text>().text = "Welcome, " + userNameInput + "!";
            PlayerPrefs.SetString("playerName", userNameInput);
            enterButton.enabled = true;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
