using UnityEngine.SceneManagement;
using UnityEngine;

public class Frog : MonoBehaviour
{
    public GameObject frog;
    public Rigidbody2D rb;

    private int currLives;
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
        }else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down);
        }

        currLives = PlayerPrefs.GetInt("lifeIndex");

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Car")
        {
            Debug.Log("WE LOST!");
            if(currLives > 1)
            {
                currLives=currLives-1;
                PlayerPrefs.SetInt("lifeIndex", currLives);
                resetFrogPosition();
            }
            else
            {
                currLives = currLives - 1;
                PlayerPrefs.SetInt("lifeIndex", 0);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            //Score.currentScore = 0;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }
    }

    void resetFrogPosition()
    {
        frog.transform.position = new Vector3(0, -4.54f, 0);
    }
}
