using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {
	public static UiManager instance;
	public GameObject gameOverPanel;
	public GameObject startUI;
	public GameObject gameOverText;
	public Text scoreText;
	public Text highScoreText;


	void Awake() {
		if(instance == null) {
			instance = this; 
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = ScoreManager.instance.score.ToString();

	}

	public void GameStart() {
		startUI.SetActive (false); // when the games starts all of the UI is going to be deactivated
	}

	public void GameOver() { // activates the game over pannel
		highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
		gameOverPanel.SetActive (true);
	}

	public void Replay() { // loads level1 scence when hit replay button
		SceneManager.LoadScene ("level1");
		
	}

	public void Menu() { // loads menu scence when hit menu button
		SceneManager.LoadScene ("Menu");
		
	}
}
