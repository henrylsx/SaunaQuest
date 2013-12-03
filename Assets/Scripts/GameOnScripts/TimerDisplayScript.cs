﻿using UnityEngine; using System.Collections;

public class TimerDisplayScript : MonoBehaviour
{
	private float currentTime;
	private float restSeconds;
	private int roundedRestSeconds;
	private float displaySeconds;
	private float displayMinutes;
	public int startSeconds = 0;
	string timetext;
	public int initialfontSize = 30;
	private bool fontSizeSet = false;

 
 
// Use this for initialization
 
	void Start ()
	{


 
	}
 
	void OnGUI ()
	{
		if (fontSizeSet == false) {
			fontSizeSet = true;
			GUI.skin.label.fontSize = initialfontSize;			
		}
		
		
			
		currentTime = Time.time;

 
		roundedRestSeconds = Mathf.CeilToInt (currentTime);
		displaySeconds = roundedRestSeconds % 60;
		displayMinutes = (roundedRestSeconds / 60) % 60;
	
		timetext = (displayMinutes.ToString () + ":");
		if (displaySeconds > 9) {
			timetext = timetext + displaySeconds.ToString ();
		} else {
			timetext = timetext + "0" + displaySeconds.ToString ();
		}
		
		GUI.Label (new Rect (600.0f, 0.0f, 100.0f, 75.0f), timetext);
	}
}