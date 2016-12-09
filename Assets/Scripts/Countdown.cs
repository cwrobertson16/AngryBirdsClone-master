//Team Diamond
//LMSC-281 Fall 2016
//Final Project (Angry Birds)

//THIS SCRIPT IS APPLIED TO THE TIMER (in heirarchy, Canvas -> Counter)

using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Allow access to edit text
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour {

	public float EasyTimer = 60;  //Amount of time that player has for the "easy" mode
	public Text timerText;


	// Use this for initialization
	void Start () {

		timerText = GetComponent<Text>(); //grab text component to edit

	
	}
	
	// Update is called once per frame
	void Update () {

		EasyTimer -= Time.deltaTime; //count downwards
		timerText.text = EasyTimer.ToString ("f0"); //make text component show current time left. "f0" used to make it control amount of decimals shown in time (in this case, no decimal points)

		//Make switch case to freeze timer if win conditions are met or losing conditions are met before timer runs out

		if (EasyTimer <= 0) {
			EasyTimer = 0;
			timerText.text = EasyTimer.ToString ("f0"); //when time is up, ensure the time says "0" instead of displaying a few decimals below 0
		}
	
	}

}

//countdown timer help from video: https://www.youtube.com/watch?v=D-6BbUozuCY