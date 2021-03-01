using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesAmountResult : MonoBehaviour
{
    public Text displayLives;

    //[SerializeField]
    private int savedLifeAmount;

    // Start is called before the first frame update
    void Start()
    {
        savedLifeAmount = PlayerPrefs.GetInt("lifeIndex");
        displayLives.text = savedLifeAmount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
