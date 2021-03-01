using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int currentScore = 0;

    public Text scoreText;

    private void Awake()
    {
        currentScore = PlayerPrefs.GetInt("playerScore");
    }
    private void Update()
    {
        scoreText.text = currentScore.ToString();
        //PlayerPrefs.SetInt("playerScore", currentScore);
    }
}
