using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public bool gameOver = false;
    public int score = 0;
    public static GameController instance;

    // Use this for initialization
    void Start () {
        instance = this;
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameOver() {
        SceneManager.LoadScene("MenuInicio");
    }
}
