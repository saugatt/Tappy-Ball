/*
 * using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	bool gameOver;

	void Awake(){
		DontDestroyOnLoad (this.gameObject);

		if (instance == null) {
			instance = this; // If no game manager then create one
		} else {
			Destroy (this.gameObject); // If there already is  an instance of game manger destroy it
		}
	}
	// Use this for initialization
	void Start () {
		gameOver = true;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GameStart() {
		UiManager.instance.GameStart ();
		GameObject.Find ("PipeSpawner").GetComponent<PipeSpawner> ().StartSpawningPipes ();
		UiManager.instance.GameStart ();
	}

	public void GameOver() {
		gameOver = false;
		GameObject.Find ("PipeSpawner").GetComponent<PipeSpawner> ().StopSpawningPipes ();
		ScoreManager.instance.StopScore ();
		UiManager.instance.GameOver ();
	}
}

*/

using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	bool gameOver;


	void Awake(){
		DontDestroyOnLoad (this.gameObject);

		if (instance == null) {
			instance = this;
		} 
		else {
			Destroy (this.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		gameOver = true;
	}

	// Update is called once per frame
	void Update () {

	}

	public void GameStart(){
		UiManager.instance.GameStart ();
		GameObject.Find ("PipeSpawner").GetComponent<PipeSpawner> ().StartSpawningPipes();

	}

	public void GameOver(){
		gameOver = false;
		GameObject.Find ("PipeSpawner").GetComponent<PipeSpawner> ().StopSpawningPipes ();
		ScoreManager.instance.StopScore ();
		UiManager.instance.GameOver ();
		UnityAdManager.instance.ShowAd ();
	}
}
