﻿using UnityEngine;
using System.Collections;

public class PipeController : MonoBehaviour {

	public float speed; // Changes the pipes position, so that it can create the effect of moving
	public float upDownSpeed; // Changes the position of the pipe upwards or downwards
	Rigidbody2D rb;



	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		MovePipe ();
		InvokeRepeating ("SwitchUpDown", 0.1f, 1f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SwitchUpDown() {
		upDownSpeed = -upDownSpeed;
		rb.velocity = new Vector2 (-speed, upDownSpeed);
	}

	void MovePipe() {
		rb.velocity = new Vector2 (-speed, upDownSpeed);

	}
}