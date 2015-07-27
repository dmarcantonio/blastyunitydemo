using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {
	
	public static float speed;
	public float startingSpeed = 2.5f;
	public static int score = 0;
	private static int highScore = 0;
	public static bool gameOver = false;
	
	// Use this for initialization
	void Start () {
		speed = startingSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(score > highScore)
			highScore = score;
		
		if(gameOver)
		{
			if(Input.GetKeyDown(KeyCode.Z)){
				gameOver=false;
				score = 0;
				Application.LoadLevel("blowups");		
			}
		}
	}
	
	void OnGUI()
	{
		GUI.Label(new Rect(0,0,200,80),"Score:" + score);
		GUI.Label(new Rect(0,20,200,80),"High Score:" + highScore);
		GUI.Label(new Rect(0,50,200,80),"Fire: Z");
		GUI.Label(new Rect(0,70,200,80),"Movement: Left and Right");
		if(gameOver)
			GUI.Label(new Rect(Screen.width/2.0f - 50, Screen.height/2.0f, 400,100), "GAME OVER - Press Z to play again.");
	}
}
