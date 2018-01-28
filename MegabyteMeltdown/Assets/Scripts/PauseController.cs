using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour {

    SceneManager scene = new SceneManager();

    public static PauseController instance;

    [SerializeField]
    private Text scoreText, coinText, lifeText;

    [SerializeField]
    private GameObject pausePanel;

    // Use this for initialization
    void Awake () {
        MakeInstance(); 
	}
	
	// Update is called once per frame
	void MakeInstance () {
		if(instance == null)
        {
            instance = this;
        }
	}

    public void PauseTheGame()
    {
        Time.timeScale = 0f;
        //GameObject.Find("Pause Panel").SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        //GameObject.Find("Pause Panel").SetActive(false);
        //pausePanel.SetActive(false);
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        //Application.LoadLevel("MainMenu");
        SceneManager.LoadScene("MainMenu");
    }

}
