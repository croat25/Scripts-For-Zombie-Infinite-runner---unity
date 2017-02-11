using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
    public Canvas quitmenu;
    public Button Starttext;
    public Button exitText;
    public Canvas startmenu;

	// Use this for initialization
	void Start () {

        quitmenu = quitmenu.GetComponent<Canvas>();
        Starttext = Starttext.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        startmenu = startmenu.GetComponent<Canvas>();
        quitmenu.enabled = false;
    }
	
	// Update is called once per frame
    public void ExitPress()
    {
        quitmenu.enabled = true;
        Starttext.enabled = false;
        exitText.enabled = false;
        startmenu.enabled = false;

    }

    public void NoPress()
    {
        quitmenu.enabled = false;
        Starttext.enabled = true;
        exitText.enabled = true;
        startmenu.enabled = true;
    }


    public void StartLevel()
    {
        SceneManager.LoadScene("game");

    }
    public void Exitgame()
    {
        Application.Quit();

    }
}
