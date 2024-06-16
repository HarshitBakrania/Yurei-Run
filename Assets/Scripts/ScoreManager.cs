using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public int score;
    public Text scoreDisplay;
    public Text highScore;

    private void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    private void Update()
    {
        scoreDisplay.text = score.ToString();
        if(score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScore.text = score.ToString();
        }
        
    }


    public Player player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (player.Health > 0)
        {
            score++;
        }
        Destroy(other.gameObject);
    }
}
