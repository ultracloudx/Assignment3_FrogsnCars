using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public GameObject frog;

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("YOU WON!");
        Score.currentScore += 100;
        PlayerPrefs.SetInt("playerScore", Score.currentScore);
        if (PlayerPrefs.GetInt("playerScore")%500 == 0 && PlayerPrefs.GetInt("playerScore") != 0)
        {
            if (PlayerPrefs.GetInt("lifeIndex") < 3)
            {
                int i = (PlayerPrefs.GetInt("lifeIndex")) + 1;
                PlayerPrefs.SetInt("lifeIndex", i);
            }
        }
        
        
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        frog.transform.position = new Vector3(0, -4.54f, 0);
    }

}
