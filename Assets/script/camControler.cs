using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControler : MonoBehaviour {

	public GameObject player;

	private Vector3 offSet;

	// Use this for initialization
	void Start () {
		offSet = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offSet;
	}
}
