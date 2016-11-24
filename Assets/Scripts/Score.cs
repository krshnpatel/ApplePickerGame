using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
	static public int score = 0;

	void Awake()
	{
		// If the ApplePickerHighScore already exists, read it
		if (PlayerPrefs.HasKey ("ApplePickerScore"))
			score = PlayerPrefs.GetInt ("ApplePickerScore");
		// Assign the high score to ApplePickerHighScore
		PlayerPrefs.SetInt("ApplePickerScore",score);
	}

	// Update is called once per frame
	void Update ()
	{
		GUIText gt = this.GetComponent<GUIText> ();
		gt.text = "Score: " + score;
		PlayerPrefs.SetInt ("ApplePickerScore", score);
	}
}
