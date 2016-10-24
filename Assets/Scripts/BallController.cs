/*
using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D rb; // defining rb as a rigid body
	public float upForce; // variable for the force for the ball
	bool started; // checks if the game has started or not
	bool gameOver; // checks if the game is over



	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		started = false;
		gameOver = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!started) {
			//GetMouseButtonDown also works for the touchscreen
			if (Input.GetMouseButtonDown (0)) {
				started = true;
				rb.isKinematic = false;
				GameManager.instance.GameStart(); // Starting the game with game manager
			}
		} else {
			if (Input.GetMouseButtonDown (0)) {
				rb.velocity = Vector2.zero;
				rb.AddForce (new Vector2 (0, upForce));
			}
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
		gameOver = false;
		GameManager.instance.GameOver ();
		UnityAdManager.instance.ShowAd (); 

	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Pipe" && !gameOver) { // if colliding for the first time
			gameOver = true;
			GameManager.instance.GameOver (); // calling the gameover method from gamemanager
		}
		if (col.gameObject.tag == "ScoreChecker"  ) {
			ScoreManager.instance.IncrementScore();
		}
	
	}
}
*/

using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	Rigidbody2D rb;
	public float upForce;
	bool started;
	bool gameOver;
	public float rotation;
	public AudioClip sound;
	private AudioSource source {get { return GetComponent<AudioSource>();}}
	public AudioClip explosion;
	private AudioSource explosionSource {get { return GetComponent<AudioSource>();}}

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		started = false;
		gameOver = false;
		gameObject.AddComponent<AudioSource> ();
		gameObject.AddComponent<AudioSource> ();
		source.clip = sound;
		explosionSource.clip = explosion;
		explosionSource.playOnAwake = false;
		source.playOnAwake = false;
		//Any other setting 

	}

	// Update is called once per frame
	void Update () {
		if (!started) {

			if (Input.GetMouseButtonDown (0)) {

				started = true;
				rb.isKinematic = false;
				GameManager.instance.GameStart ();
				source.PlayOneShot (sound);

			}
		} 
		else if(started && !gameOver){

			transform.Rotate (0, 0, rotation);


			if (Input.GetMouseButtonDown (0)) {
				rb.velocity = Vector2.zero;
				rb.AddForce (new Vector2 (0, upForce));
				source.PlayOneShot (sound);


			}
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		gameOver = true;
		GameManager.instance.GameOver ();
		UnityAdManager.instance.ShowAd ();
		source.PlayOneShot (explosion);


	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Pipe" && !gameOver) {
			source.PlayOneShot(explosion);
			UnityAdManager.instance.ShowAd ();
			gameOver = true;
			GameManager.instance.GameOver ();

					}

		if (col.gameObject.tag == "ScoreChecker" && !gameOver) {
			ScoreManager.instance.IncrementScore ();
		}
	}
}
