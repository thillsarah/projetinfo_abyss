using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {
	
    public static GameControl instance;
	public GameObject gameOverText;
	public bool gameOver = false;
	public Text scoreText;

	private int score = 0;

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
