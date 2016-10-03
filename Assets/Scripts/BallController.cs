using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D rb; // defining rb as a rigid body
	public float upForce; // variable for the force for the ball
	bool started; // checks if the game has started or not



	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		started = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!started) {
			//GetMouseButtonDown also works for the touchscreen
			if (Input.GetMouseButtonDown (0)) {
				UnityAdManager.instance.ShowAd (); 
				started = true;
				rb.isKinematic = false;
			}
		} else {
			if (Input.GetMouseButtonDown (0)) {
				rb.velocity = Vector2.zero;
				rb.AddForce (new Vector2 (0, upForce));
			}
		}
	
	}
}
