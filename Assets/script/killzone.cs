using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killzone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.name == "Boatv2") {
			Application.LoadLevel ("roll a ball");
		} else {
			Destroy (other.gameObject);
		}
	}

}
