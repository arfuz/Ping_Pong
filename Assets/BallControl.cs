using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {
	float ballSpeed = 115;
	Rigidbody2D rBody; // Use this for initialization 

	IEnumerator Start () { 
		yield return new WaitForSeconds (1f);
		GoBall ();
		
	}
	IEnumerator ResetBall(){
		rBody.velocity = new Vector2 (0, 0);
		transform.position = new Vector2 (0, 0);
		yield return new WaitForSeconds (1f);
		GoBall ();
	}	

	void GoBall(){
		rBody = GetComponent < Rigidbody2D> ();    
		float randomNumber = Random.Range (0, 10);    
		if (randomNumber <= 0.5) {       
			rBody.AddForce (new Vector2 (ballSpeed, 10));    
		} else {      
			rBody.AddForce (new Vector2 (-ballSpeed, -10));    
		}
	}
	void OnCollisionEnter2D(Collision2D colInfo){     
		if (colInfo.collider.tag == "Player") {     
			float velY = rBody.velocity.y;    
			rBody.velocity = new Vector2(rBody.velocity.x , velY/2 + colInfo.collider.GetComponent<Rigidbody2D>().velocity.y/3);   
		} 
	}
}