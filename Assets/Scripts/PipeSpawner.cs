using UnityEngine;
using System.Collections;

public class PipeSpawner : MonoBehaviour {

	public float maxYpos;
	public float SpwanTime;
	public GameObject pipe;

	// Use this for initialization
	void Start () { //Commenting startSpawning Pipes since we are calling it from game manager
		StartSpawningPipes ();	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartSpawningPipes() {
		InvokeRepeating ("SpawnPipe", 0.2f, SpwanTime);
	}

	public void StopSpawningPipes() {
		CancelInvoke ("SpawnPipe");
	}

	void SpawnPipe() {
		Instantiate (pipe, new Vector3 (transform.position.x, Random.Range (4, 10), 0), Quaternion.identity); 
		// Quaternion.identity means no rotation to the pipe
	}
}
