using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class UnityAdManager : MonoBehaviour {

	public static UnityAdManager instance;

	void Awake() {
		DontDestroyOnLoad(this.gameObject);

		if (instance == null) {
			instance = this;
		} else {
			Destroy (this.gameObject);
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ShowAd() {
		if (Advertisement.IsReady ("rewardedVideo")) {
			Advertisement.Show ("rewardedVideo");
		}
	}
}
