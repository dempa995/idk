using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arv : MonoBehaviour {

	//sin curve vesion
	public float frequency = 1.0f;  // Speed of sine movement
	public float magnitude = 0.5f;   // Size of sine movement
	protected Vector3 axis;
	protected Vector3 pos;

	// Use this for initialization
	void Start () {


		//sine curve
		pos = transform.position;
		axis = transform.up;  // May or may not be the axis you want

		frequency = 1.0f;

	}

	// Update is called once per frame
	protected void FirstUpdate () {

		//Using a sine kurve
		transform.position = pos + axis * Mathf.Sin (Time.time * frequency) * magnitude;
	}
	
}
