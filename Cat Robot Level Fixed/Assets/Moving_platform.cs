using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_platform : MonoBehaviour {
	public GameObject startpoint;
	public GameObject endpoint;
	public float move_speed;
	bool atendpoint = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (atendpoint) {
			transform.position = Vector3.MoveTowards (transform.position, startpoint.transform.position, move_speed);
		} 
		else {
			transform.position = Vector3.MoveTowards (transform.position, endpoint.transform.position, move_speed);
		}
		if (transform.position == startpoint.transform.position)
			atendpoint = false;
		if (transform.position == endpoint.transform.position)
			atendpoint = true;
	}
	void OnCollisionEnter (Collision other) {
		if (other.gameObject.tag == "Player")
			other.gameObject.transform.parent = gameObject.transform;
	}

	void OnCollisionExit (Collision other) {
		if (other.gameObject.tag == "Player")
			other.gameObject.transform.parent = null;
	}
}
