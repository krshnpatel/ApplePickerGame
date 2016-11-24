using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
	public void LoadScene(string name)
	{
		Application.LoadLevel (name);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}

	public void ResetHighScore()
	{
		HighScore.score = 0;
		PlayerPrefs.SetInt ("ApplePickerHighScore", HighScore.score);
	}
}