using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float delay = 0.5f;
    public GameObject levelWonUI;

    public void CompleteLevel()
    {
        levelWonUI.SetActive(true);
        Debug.Log("End Reached"); //when the player reaches the end, enable to level won UI screen
    }

    public void GameOver()
    {
        Debug.Log("GAME OVER"); 
        Invoke("Restart", delay); //delay before the actual restart of the level happens
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //resets player position and they go back to the start
    }
}
