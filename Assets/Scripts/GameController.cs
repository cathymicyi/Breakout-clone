using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class GameController : MonoBehaviour {
	public static GameController gm;
    public int lives = 3;
	public int scores = 0;
    public GameObject brickGroup;
    public float resetWait = 2f;
    public GameObject gameOverText;
    public GameObject successText;
    public GameObject livesText;
	public GameObject scoreText;//store score
	public string LevelafterVic;
	public string LevelafterOver;
	public AudioClip sound;
	public AudioClip sound2;
	public AudioSource _audio;
	Scene  _scene;

    public int numberOfBricks { get; set; }
    // Use this for initialization
	void awake(){
		if (gm == null)
			gm = this.GetComponent<GameController> ();
		
		setDefault ();
	}
    void Start () {
		
        numberOfBricks = brickGroup.transform.childCount;
		Debug.Log (numberOfBricks);
		_audio.GetComponent<AudioSource> ();
    }
	
	// Update is called once per frame
	void Update () {
        livesText.GetComponent<Text>().text = "Lives: " + lives;
		scoreText.GetComponent<Text> ().text = "Scores:" + scores;

        if(lives == 0) {
            livesText.SetActive(false);
			scoreText.SetActive (false);
            gameOverText.SetActive(true);
			FinalResult.Getscore (scores);

			_audio.PlayOneShot (sound);
			StartCoroutine(Mywait(LevelafterOver));
			//SceneManager.LoadScene (LevelafterOver);
           // StartCoroutine(countDownAndRestart());
        }

        if(numberOfBricks == 0) {
            livesText.SetActive(false);
            successText.SetActive(true);
			FinalResult.Getscore (scores);
			_audio.PlayOneShot (sound2);
			StartCoroutine(Mywait(LevelafterVic));
		//	SceneManager.LoadScene (LevelafterVic);
           // StartCoroutine(countDownAndRestart());
        }

		if (Input.GetButtonDown("Cancel")) {
			Debug.Log ("log out game");
			Application.Quit ();
		}
			
	}
	void setDefault(){//for game over
		if (LevelafterVic == "") {
			_scene = SceneManager.GetActiveScene ();
			Debug.Log ("set after victory");
			LevelafterVic = _scene.name;
		}
		if (LevelafterOver == "") {
			Debug.Log ("set after game over");
			LevelafterOver = _scene.name;
		}


	}

	IEnumerator Mywait(string level) {//for vic mayby create different level.

		yield return new WaitForSeconds(3);
		SceneManager.LoadScene (level);

   }
}
