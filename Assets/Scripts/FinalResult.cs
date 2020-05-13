using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalResult : MonoBehaviour {

	// Use this for initialization 
	//buttons
	public GameObject Exit;
	public GameObject Menu;
	public GameObject PlayAgain;
	//final text
	public Text result;
	int scores;
	string name;

	

	void Update () {
		scores = PlayerPrefs.GetInt ("score");
		name = PlayerPrefs.GetString("name");
		result.text = "Name: " + name.ToString () +", " + "Score: " + scores.ToString ();
		
	}

	public void quit(){
		Debug.Log ("BYE");
		Application.Quit ();
	}
	public void Load(string scenename)
	{
		//PlayerPrefs.DeleteAll ();
		SceneManager.LoadScene (scenename);
	}


	public  static void Getscore(int _score){
		PlayerPrefs.SetInt ("score", _score);

		Debug.Log (_score);
		
	}

	public static void Getname(string _name){
		PlayerPrefs.SetString ("name", _name);

		Debug.Log (_name);
	}

}
