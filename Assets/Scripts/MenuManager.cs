using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour {
	//buttoms
	public GameObject Newgame;
	public GameObject exitgame;
	public GameObject next;
	//switch menu
	public GameObject Namepanel;
	public GameObject _mainmenu;
	//input field
	public InputField User;

	private string username;

	// Use this for initialization
	void Awake () {
		showmenu ("Mainmenu");
		
	}
	
	// Update is called once per frame
	void Update () {
		Username ();
		
	}
	void Username(){
		
		//Debug.Log()
		FinalResult.Getname (User.text);
	
	}
	public void load(){
		SceneManager.LoadScene ("Breakout");
	}
	public void quit(){
		Debug.Log ("BYE");
		Application.Quit ();
	}

	public void showmenu(string name){
		_mainmenu.SetActive (false);
		Namepanel.SetActive (false);
		switch (name) {
		case "Mainmenu":
			_mainmenu.SetActive (true);
			break;
		case "Userpanel":
			Namepanel.SetActive (true);
			break;
		}
	
	
	}
}
