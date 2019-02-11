using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedPlatform : MonoBehaviour {
	public GameObject Platforms;
	public int Timer;
	public int TimerLength;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Timer > 0)
			Timer--;
		if (Timer < 1)
			Platforms.SetActive (false);
	}
	void OnCollisionEnter (Collision other){
		if (other.gameObject.tag == "Player") {
			Timer = TimerLength;
			Platforms.SetActive (true);
		}
	}
}
