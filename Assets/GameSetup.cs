using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class GameSetup : MonoBehaviour { 
	public Camera mainCam; 
	public BoxCollider2D topWall; 
	public BoxCollider2D bottomWall; 
	public BoxCollider2D leftWall; 
	public BoxCollider2D rightWall; 
	public Transform Player1; 
	public Transform Player2; 

	void Start() {
		this.topWall.size = new Vector2 ( mainCam.ScreenToWorldPoint (new Vector3 (Screen.width * 2f, 0f, 0f)).x, 1f); 
		this.topWall.offset = new Vector2 (0f, mainCam.ScreenToWorldPoint (new Vector3 (0f, Screen.height, 0f)).y + 0.5f); 

		this.bottomWall.size = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3 (Screen.width * 2, 0f, 0f)).x, 1f); 
		this.bottomWall.offset = new Vector2 (0f, mainCam.ScreenToWorldPoint (new Vector3( 0f, 0f, 0f)).y - 0.5f); 

		this.leftWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height*2f, 0f)).y); 
		this.leftWall.offset = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f); 

		this.rightWall.size = new Vector2(1f, mainCam.ScreenToWorldPoint(new Vector3(0f, Screen.height*2f, 0f)).y); 
		this.rightWall.offset = new Vector2(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f); 

		this.Player1.position = new Vector2(mainCam.ScreenToWorldPoint (new Vector3 (75f, 0f, 0f)).x, 0f); 
		this.Player2.position = new Vector2(mainCam.ScreenToWorldPoint (new Vector3 (Screen.width -75f, 0f, 0f)).x, 0f);
	} // Update is called once per frame 
	void Update () { 
	} 
}﻿