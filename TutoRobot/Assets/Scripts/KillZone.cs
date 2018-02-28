using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KillZone : MonoBehaviour {

	public static GameControl instance;
	public GameObject gameOverText;
	public bool gameOver = false;
	public Text scoreText;

    private int score = 0;

    private void OnTriggerEnter2D (Collider2D other) 
    {
        if(other.tag == "Player")
        {

			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}

	public void RobotScored()
	{
		if (gameOver)
		{
			return;
		}
		score++;
		scoreText.text = "Score: " + score.ToString();
	}

	public void RobotDied()
	{
		gameOverText.SetActive(true);
		gameOver = true;
	}
}
