using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour {
    public GameObject pausePanel;

    public bool isPaused;

	// Use this for initialization
	void Start () {
        isPaused = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isPaused)
        {
            PauseGame(true);

        }
        else
        {
            PauseGame(false);

        }
        if (Input.GetButtonDown("Cancel"))
        {
            switchpause();
        }
	}

    void PauseGame (bool state)
    {
        if (state)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;     
        }
        pausePanel.SetActive(state);
    }

    public void switchpause()
    {
        if (isPaused)
        {
            isPaused = false;//changes the value
        }
        else
        {
            isPaused = true;
        }
    }
    public void StartLevel()
    {
        SceneManager.LoadScene("game", LoadSceneMode.Single);
        switchpause();
    }

    public void Exitgame()
    {
        Application.Quit();

    }
}
