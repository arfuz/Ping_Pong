using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	static int PlayerScore01 = 0;
	static int PlayerScore02 = 0;

	public GUISkin theSkin;

	// Use this for initialization
	public static void  Score(string wallName) 
	{
		Debug.Log (wallName);
		if(wallName == "rightWall")
		{
			PlayerScore01 += 1;

		}
		else
		{
			PlayerScore02 += 1;

		}
		Debug.Log("Player Score 1 is " + PlayerScore01);
		Debug.Log("Player Score 2 is " + PlayerScore02);
	}

	// Update is called once per frame
	void OnGUI()
	{
		GUI.skin = theSkin;
		GUI.Label (new Rect (Screen.width / 2 - 150 - 12, 25, 100, 100), "" + PlayerScore01);
		GUI.Label (new Rect (Screen.width / 2 + 150 - 12, 25, 100, 100), "" + PlayerScore02);
	}
}