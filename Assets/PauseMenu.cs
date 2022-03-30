using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool Paused = false;
    public GameObject PauseUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) //when p is pressed...
        {
            if (Paused) //if game is paused, resume the game
            {
                Resume();
            }
            else  //if game isn't paused, pause the game
            {
                Pause();
            }
        }
    }

    public void Resume() //resumes the game when paused
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }

    void Pause() //pauses the game 
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
    }

    public void loadMainMenu() //loads the main menu
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;        
        Paused = false;
        SceneManager.LoadScene(0);
    }

    public void quitGame() //quits the game
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }
}
