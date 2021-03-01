using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Slider speedSlider;
    public Text valueOfSlider;
    public InputField playerNameInput;

    private static float carSpeed;

    [SerializeField]
    private Toggle toggle;
    [SerializeField]
    private AudioSource myAudio;

    public void Awake()
    {
        
        if (!PlayerPrefs.HasKey("music"))
        {
            PlayerPrefs.SetInt("music", 1);
            toggle.isOn = true;
            myAudio.enabled = true;
            PlayerPrefs.Save();
        }
        else
        {
            if (PlayerPrefs.GetInt("music") == 0)
            {
                myAudio.enabled = false;
                toggle.isOn = false;
            }
            else
            {
                myAudio.enabled = true;
                toggle.isOn = true;
            }
        }
    }

    public void newGameButtonMethod()
    {
        int i = 0;
        PlayerPrefs.SetInt("playerScore", i);
        Debug.Log(PlayerPrefs.GetInt("playerScore"));
        PlayerPrefs.SetString("playerName", "");
        PlayerPrefs.SetFloat("carSpeed", 0f);
        PlayerPrefs.SetInt("lifeIndex", 1);
    }

    public void ToggleMusic()
    {
        if (toggle.isOn)
        {
            PlayerPrefs.SetInt("music", 1);
            myAudio.enabled = true;
        } else
        {
            PlayerPrefs.SetInt("music", 0);
            myAudio.enabled = false;
        }
        PlayerPrefs.Save();
    }


    public void playButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void continueButton() //must include code to retrieve save data
    {
        if (PlayerPrefs.GetInt("lifeIndex") > 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void sliderValueText()
    {
        valueOfSlider.text = speedSlider.value.ToString("");
        carSpeed = speedSlider.value;
        Debug.Log(carSpeed);
        PlayerPrefs.SetFloat("carSpeed", carSpeed);
    }

    public void setLifeAmount(int lifeIndex)
    {
        int i = 0;
        switch (lifeIndex)
        {
            
            case 0:
                PlayerPrefs.SetInt("lifeIndex", 1);
                i = PlayerPrefs.GetInt("lifeIndex");
                Debug.Log(i);
                break;
            case 1:
                PlayerPrefs.SetInt("lifeIndex", 2);
                i = PlayerPrefs.GetInt("lifeIndex");
                Debug.Log(i);
                break;
            case 2:
                
                PlayerPrefs.SetInt("lifeIndex", 3);
                i = PlayerPrefs.GetInt("lifeIndex");
                Debug.Log(i);
                break;
            default:
                
                PlayerPrefs.SetInt("lifeIndex", 1);
                i = PlayerPrefs.GetInt("lifeIndex");
                Debug.Log(i);
                break;
        }
    }

    

    // Start is called before the first frame update
    void Start()
    {
        valueOfSlider.text = speedSlider.value.ToString(""); //float with zero decimals

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
