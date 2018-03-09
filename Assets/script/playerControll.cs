using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControll : MonoBehaviour{

	float HpMax = 3;
	float CurentHp;
	float Test = 1;

	public Rigidbody rb;
	public float speed;
	public int forceConst = 50;
	public bool canJump; 

	Points poang;


	void start ()
	{
		rb = GetComponent<Rigidbody> ();

	
	
	}
		
	void  Update ()
	{
		
		float MoveHorizontal = Input.GetAxis ("Horizontal"); 
		float moveVertical = Input.GetAxis ("Vertical");  
	
		Vector3 movment = new Vector3 (MoveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movment * speed * Time.deltaTime);
		if (Input.GetKeyUp (KeyCode.Space)) {
			canJump = true;
		}

		if (canJump) {
			canJump = false;
			rb.AddForce (0, forceConst, 0, ForceMode.Impulse);

		}

	}//END Update()	

	void OnTriggerEnter(Collider other) 
	{

		if ( other.gameObject.CompareTag("cube") )
		{
			other.gameObject.SetActive (false);
		}

		    

	}//END OnTriggerEnter()
	void OnCollisionEnter(Collision Obsticol ){

		if (Obsticol.gameObject.tag == "Obsticol") {
			
			HpMax--;  

			CurentHp = HpMax; 
			}
		if (HpMax == 0){
			Application.LoadLevel ("roll a ball");

		}
	
	}



}

