using UnityEngine;
using System.Collections;

public class PipeSpawner : MonoBehaviour {

	public float maxYpos;
	public float SpwanTime;
	public GameObject Pipe;

	// Use this for initialization
	void Start () {
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

	void SpwanPipe() {
		Instantiate (Pipe, new Vector3 (transform.position.x, Random.Range (-maxYpos, maxYpos), 0), Quaternion.identity); 
		// Quaternion.identity means no rotation to the pipe
	}
}
