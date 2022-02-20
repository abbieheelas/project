using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //loads the next scene in the queue
                                                                              //(lvl1 in this instance, but if more levels
                                                                              //complete, then it'd continue to that level.)
    }

    public void Quit()
    {
        Debug.Log("Quit Game"); //quits game and writes to console to confirm it works
        Application.Quit();
    }
}
