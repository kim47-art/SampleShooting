using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
	int score = 0;
	GameObject scoreText;
	GameObject gameOverText;

	public void GameOver()
	{
		this.gameOverText.GetComponent<TMPro.TMP_Text>().text = "GameOver";
	}

	public void AddScore()
	{
		this.score += 10;
	}

	// Use this for initialization
	void Start()
	{
		this.scoreText = GameObject.Find("Score");
		this.gameOverText = GameObject.Find("GameOver");
	}

	void Update()
	{
		scoreText.GetComponent<TMPro.TMP_Text>().text = "Score:" + score.ToString("D4");
	}
}
