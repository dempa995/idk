using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotasion : arv{
	
	// Update is called once per frame
	void Update () {
		 
		FirstUpdate ();
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}


}
