using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Text displayScore;
    public Text displayName;
    Text displayLives;
    public Image oneHeart;
    public Image twoHeart;
    public Image threeHeart;

    [SerializeField]
    private string playerName;
    [SerializeField]
    private AudioSource myAudio;
    [SerializeField]
    private int savedScore;
    [SerializeField]
    private int savedLifeAmount;

    public void Awake()
    {
        if (!PlayerPrefs.HasKey("music"))
        {
            PlayerPrefs.SetInt("music", 1);
            //toggle.isOn = true;
            myAudio.enabled = true;
            PlayerPrefs.Save();
        }
        else
        {
            if (PlayerPrefs.GetInt("music") == 0)
            {
                myAudio.enabled = false;
                //toggle.isOn = false;
            }
            else
            {
                myAudio.enabled = true;
                //toggle.isOn = true;
            }
        }

        playerName = PlayerPrefs.GetString("playerName");
        displayName.GetComponent<Text>().text = playerName;

        savedScore = PlayerPrefs.GetInt("playerScore");
        displayScore.text = savedScore.ToString();

        //savedLifeAmount = PlayerPrefs.GetInt("lifeIndex");
        //displayLives.text = savedLifeAmount.ToString();
        setHearts(savedLifeAmount);
    }

    public void setHearts(int amountOfLives)
    {
        switch (amountOfLives)
        {
            case 0:
                oneHeart.GetComponent<Image>().enabled = false;
                twoHeart.GetComponent<Image>().enabled = false;
                threeHeart.GetComponent<Image>().enabled = false;
                break;
            case 1:
                oneHeart.GetComponent<Image>().enabled = true;
                twoHeart.GetComponent<Image>().enabled = false;
                threeHeart.GetComponent<Image>().enabled = false;
                break;
            case 2:
                oneHeart.GetComponent<Image>().enabled = false;
                twoHeart.GetComponent<Image>().enabled = true;
                threeHeart.GetComponent<Image>().enabled = false;
                break;
            case 3:
                oneHeart.GetComponent<Image>().enabled = false;
                twoHeart.GetComponent<Image>().enabled = false;
                threeHeart.GetComponent<Image>().enabled = true;
                break;
            default:
                oneHeart.GetComponent<Image>().enabled = true;
                twoHeart.GetComponent<Image>().enabled = false;
                threeHeart.GetComponent<Image>().enabled = false;
                break;
        }
        
    }

    private void FixedUpdate()
    {
        savedLifeAmount = PlayerPrefs.GetInt("lifeIndex");
        setHearts(savedLifeAmount);
        /*savedScore = Score.currentScore;
        PlayerPrefs.SetInt("playerScore", savedScore);*/
    }

    public void mainMenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void quitButton()
    {
        Debug.Log("Quit successful");
        Application.Quit();
    }

    public void quitFromMainButton()
    {
        Debug.Log("Quit successful");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
